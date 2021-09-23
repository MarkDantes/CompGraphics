namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
=======
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.chartR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).BeginInit();
>>>>>>> main
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(579, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.PictureBox1_LoadCompleted);
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(493, 397);
=======
            this.button1.Location = new System.Drawing.Point(836, 614);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> main
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
<<<<<<< HEAD
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(194, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(196, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(196, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "V";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(222, 193);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(154, 56);
            this.trackBar1.TabIndex = 12;
            //this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.trackBar1.ValueChanged +=
        new System.EventHandler(TrackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(222, 255);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(158, 56);
            this.trackBar2.TabIndex = 13;
            //this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            this.trackBar2.ValueChanged +=
        new System.EventHandler(TrackBar2_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(222, 317);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(158, 56);
            this.trackBar3.TabIndex = 14;
            //this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3_Scroll);
            this.trackBar3.ValueChanged +=
        new System.EventHandler(TrackBar3_ValueChanged);
=======
            // pictureBoxRed
            // 
            this.pictureBoxRed.Location = new System.Drawing.Point(35, 114);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(226, 150);
            this.pictureBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRed.TabIndex = 2;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Location = new System.Drawing.Point(311, 114);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(226, 150);
            this.pictureBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreen.TabIndex = 3;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Location = new System.Drawing.Point(35, 330);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(226, 150);
            this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBlue.TabIndex = 4;
            this.pictureBoxBlue.TabStop = false;
            // 
            // chartR
            // 
            chartArea7.Name = "ChartArea1";
            this.chartR.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartR.Legends.Add(legend7);
            this.chartR.Location = new System.Drawing.Point(8, 498);
            this.chartR.Name = "chartR";
            this.chartR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartR.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartR.Series.Add(series7);
            this.chartR.Size = new System.Drawing.Size(564, 256);
            this.chartR.TabIndex = 5;
            this.chartR.Text = "chart1";
            // 
            // chartG
            // 
            chartArea8.Name = "ChartArea1";
            this.chartG.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartG.Legends.Add(legend8);
            this.chartG.Location = new System.Drawing.Point(12, 774);
            this.chartG.Name = "chartG";
            this.chartG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartG.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartG.Series.Add(series8);
            this.chartG.Size = new System.Drawing.Size(564, 256);
            this.chartG.TabIndex = 6;
            this.chartG.Text = "chart2";
            // 
            // chartB
            // 
            chartArea9.Name = "ChartArea1";
            this.chartB.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartB.Legends.Add(legend9);
            this.chartB.Location = new System.Drawing.Point(595, 774);
            this.chartB.Name = "chartB";
            this.chartB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartB.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartB.Series.Add(series9);
            this.chartB.Size = new System.Drawing.Size(564, 256);
            this.chartB.TabIndex = 7;
            this.chartB.Text = "chart3";
>>>>>>> main
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
=======
            this.ClientSize = new System.Drawing.Size(1200, 1155);
            this.Controls.Add(this.chartB);
            this.Controls.Add(this.chartG);
            this.Controls.Add(this.chartR);
            this.Controls.Add(this.pictureBoxBlue);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.pictureBoxRed);
>>>>>>> main
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartB)).EndInit();
>>>>>>> main
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
=======
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartB;
>>>>>>> main
    }
}

