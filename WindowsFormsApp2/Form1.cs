using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string imageLocation = "";
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "PNG files|*.png| jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBox1.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
