using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Image files|*.png| Image files(*.jpg)|*.jpg| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.LoadAsync(dialog.FileName);
                    //pictureBox1.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }

        public (double H, double S, double V) RGBtoHSV(Color c)
        {
            var R = c.R / 255d;
            var G = c.G / 255d;
            var B = c.B / 255d;
            double max = Math.Max(R, Math.Max(G, B));
            double min = Math.Min(R, Math.Min(G, B));
            double H, S, V;
            if (max == min)
                H = 0;
            else
                if (max == R && G >= B)
                H = 60 * (G - B) / (max - min);
            else
                    if (max == R && G < B)
                H = 60 * (G - B) / (max - min) + 360;
            else
                    if (max == G)
                H = 60 * (B - R) / (max - min) + 120;
            else
                if (max == B)
                H = 60 * (R - G) / (max - min) + 240;
            else
                H = 0;


            if (max == 0)
                S = 0;
            else
                S = 1d - (1d*min / max);

            V = max;
            
            return (H, S, V);
        }
        public (double R, double G, Double B) HSVtoRGB( double H, double S, double V)
        {
            
            int hi = Convert.ToInt32(Math.Floor(H / 60)) % 6;
            double f = H / 60 - Math.Floor(H / 60);
            V *= 255;
            int v = Convert.ToInt32(V);
            int p = Convert.ToInt32(V * (1 - S));
            int q = Convert.ToInt32(V * (1 - f * S));
            int t = Convert.ToInt32(V * (1 - (1 - f) * S));

            if (hi == 0)
                return (v, t, p);
            else if (hi == 1)
                return (q, v, p);
            else if (hi == 2)
                return (p, v, t);
            else if (hi == 3)
                return (p, q, v);
            else if (hi == 4)
                return (t, p, v);
            else
                return (v, p, q);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                //создание диалогового окна "Сохранить как..", для сохранения изображения
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 360;
            

            Bitmap image = new Bitmap(pictureBox1.Image);
            Color color;

            for (int x = 0; x < pictureBox1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Image.Height; y++)

                {
                    color = image.GetPixel(x, y);
                    var (H, S, V) = RGBtoHSV(color);
                    var (R,G,B) = HSVtoRGB(1d * trackBar1.Value, S, V);
                    
                    image.SetPixel(x, y, Color.FromArgb((int)R, (int)G, (int)B));
                    
                }
                
            }
            pictureBox1.Image = image;
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 100;
            
            
            Bitmap image = new Bitmap(pictureBox1.Image);
            Color color;

            for (int y = 0; y < pictureBox1.Image.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Image.Width; x++)
                {
                    color = image.GetPixel(x, y);
                    var (H, S, V) = RGBtoHSV(color);
                    var (R, G, B) = HSVtoRGB(H, 1d * trackBar2.Value/100, V);

                    image.SetPixel(x, y, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }
            pictureBox1.Image = image;
        }
   

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 100;



            Bitmap image = new Bitmap(pictureBox1.Image);
            Color color;

            for (int y = 0; y < pictureBox1.Image.Height; y++)
            {
                for (int x = 0; x < pictureBox1.Image.Width; x++)
                {
                    color = image.GetPixel(x, y);
                    var (H, S, V) = RGBtoHSV(color);
                    var (R, G, B) = HSVtoRGB(H, S, 1d * trackBar3.Value/100);

                    image.SetPixel(x, y, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }
            pictureBox1.Image = image;
        }

        enum ColorChannel
        {
            R,G,B,
        }

        private Bitmap highlightChannel(ColorChannel channel, Image image)
        {
            Bitmap bitmap_image = new Bitmap(image);
            for (int i = 0; i < bitmap_image.Width; i++)
            {
                for (int j = 0; j < bitmap_image.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    var actualColor = bitmap_image.GetPixel(i, j);
                    var valueAlpha = actualColor.A;
                    switch (channel)
                    {
                        case ColorChannel.R:
                            {
                                var value = actualColor.R;
                                var newColor = Color.FromArgb(valueAlpha, value, 0, 0);
                                bitmap_image.SetPixel(i, j, newColor);
                                break;
                            }
                        case ColorChannel.G:
                            {
                                var value = actualColor.G;
                                var newColor = Color.FromArgb(valueAlpha, 0, value, 0);
                                bitmap_image.SetPixel(i, j, newColor);
                                break;
                            }
                        case ColorChannel.B:
                            {
                                var value = actualColor.B;
                                var newColor = Color.FromArgb(valueAlpha, 0, 0, value);
                                bitmap_image.SetPixel(i, j, newColor);
                                break;
                            }
                        default: break;
                    }
                }
            }
            return bitmap_image;

        }

        private int[] createDataForChart(ColorChannel channel, Image image)
        {
            int[] color = new int[256];
            Bitmap bitmap_image = new Bitmap(image);
            for (int i = 0; i < bitmap_image.Width; i++)
            {
                for (int j = 0; j < bitmap_image.Height; j++)
                {
                    //get the pixel from the scrBitmap image
                    var actualColor = bitmap_image.GetPixel(i, j);
                    switch (channel)
                    {
                        case ColorChannel.R:
                            {
                                var value = actualColor.R;
                                color[value]++;
                                break;
                            }
                        case ColorChannel.G:
                            {
                                var value = actualColor.G;
                                color[value]++;
                                break;
                            }
                        case ColorChannel.B:
                            {
                                var value = actualColor.B;
                                color[value]++;
                                break;
                            }
                        default: break;
                    }
                }
            }
            return color;
        }
        

        private void PictureBox1_LoadCompleted(Object sender, AsyncCompletedEventArgs e)
        {
            var redImage = highlightChannel(ColorChannel.R, pictureBox1.Image);
            var greenImage = highlightChannel(ColorChannel.G, pictureBox1.Image);
            var blueImage = highlightChannel(ColorChannel.B, pictureBox1.Image);

            pictureBoxRed.Image = redImage;
            pictureBoxGreen.Image = greenImage;
            pictureBoxBlue.Image = blueImage;

            var valuesRed = createDataForChart(ColorChannel.R, pictureBox1.Image);
            var valuesGreen = createDataForChart(ColorChannel.G, pictureBox1.Image);
            var valuesBlue = createDataForChart(ColorChannel.B, pictureBox1.Image);

            this.chartR.Series.Clear();
            this.chartG.Series.Clear();
            this.chartB.Series.Clear();

            for (int i = 0; i < 256; i++)
            {
                Series series = this.chartR.Series.Add(i.ToString());
                series.Points.Add(valuesRed[i]);
                series = this.chartG.Series.Add(i.ToString());
                series.Points.Add(valuesGreen[i]);
                series = this.chartB.Series.Add(i.ToString());
                series.Points.Add(valuesBlue[i]);
            }
            
        }


    }
}
