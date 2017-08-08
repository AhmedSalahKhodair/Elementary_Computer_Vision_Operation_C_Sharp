namespace CVPackage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Load_Image = new System.Windows.Forms.Button();
            this.Loaded_Image_PictureBox = new System.Windows.Forms.PictureBox();
            this.Generated_Image_PictureBox = new System.Windows.Forms.PictureBox();
            this.Filter_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Max_Pixel_Value_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Min_Pixel_Value_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Filter_ComboBox = new System.Windows.Forms.ComboBox();
            this.Load_Image_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Histogram_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B_Textbox = new System.Windows.Forms.TextBox();
            this.Threshold_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Harris_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Loaded_Image_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Generated_Image_PictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram_Chart)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_Image
            // 
            this.Load_Image.Location = new System.Drawing.Point(130, 311);
            this.Load_Image.Name = "Load_Image";
            this.Load_Image.Size = new System.Drawing.Size(78, 32);
            this.Load_Image.TabIndex = 0;
            this.Load_Image.Text = "Load Image";
            this.Load_Image.UseVisualStyleBackColor = true;
            this.Load_Image.Click += new System.EventHandler(this.Load_Image_Click);
            // 
            // Loaded_Image_PictureBox
            // 
            this.Loaded_Image_PictureBox.Location = new System.Drawing.Point(6, 14);
            this.Loaded_Image_PictureBox.Name = "Loaded_Image_PictureBox";
            this.Loaded_Image_PictureBox.Size = new System.Drawing.Size(288, 280);
            this.Loaded_Image_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Loaded_Image_PictureBox.TabIndex = 1;
            this.Loaded_Image_PictureBox.TabStop = false;
            // 
            // Generated_Image_PictureBox
            // 
            this.Generated_Image_PictureBox.Location = new System.Drawing.Point(6, 14);
            this.Generated_Image_PictureBox.Name = "Generated_Image_PictureBox";
            this.Generated_Image_PictureBox.Size = new System.Drawing.Size(288, 280);
            this.Generated_Image_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Generated_Image_PictureBox.TabIndex = 2;
            this.Generated_Image_PictureBox.TabStop = false;
            // 
            // Filter_Button
            // 
            this.Filter_Button.AllowDrop = true;
            this.Filter_Button.Location = new System.Drawing.Point(472, 22);
            this.Filter_Button.Name = "Filter_Button";
            this.Filter_Button.Size = new System.Drawing.Size(90, 32);
            this.Filter_Button.TabIndex = 3;
            this.Filter_Button.Text = "Filter";
            this.Filter_Button.UseVisualStyleBackColor = true;
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Loaded_Image_PictureBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Min Value";
            // 
            // Max_Pixel_Value_Textbox
            // 
            this.Max_Pixel_Value_Textbox.Enabled = false;
            this.Max_Pixel_Value_Textbox.Location = new System.Drawing.Point(400, 205);
            this.Max_Pixel_Value_Textbox.Name = "Max_Pixel_Value_Textbox";
            this.Max_Pixel_Value_Textbox.Size = new System.Drawing.Size(46, 20);
            this.Max_Pixel_Value_Textbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max Value";
            // 
            // Min_Pixel_Value_Textbox
            // 
            this.Min_Pixel_Value_Textbox.Enabled = false;
            this.Min_Pixel_Value_Textbox.Location = new System.Drawing.Point(341, 205);
            this.Min_Pixel_Value_Textbox.Name = "Min_Pixel_Value_Textbox";
            this.Min_Pixel_Value_Textbox.Size = new System.Drawing.Size(45, 20);
            this.Min_Pixel_Value_Textbox.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Generated_Image_PictureBox);
            this.groupBox2.Location = new System.Drawing.Point(582, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Image";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Filter_ComboBox);
            this.groupBox3.Location = new System.Drawing.Point(341, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 46);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // Filter_ComboBox
            // 
            this.Filter_ComboBox.FormattingEnabled = true;
            this.Filter_ComboBox.Items.AddRange(new object[] {
            "Average",
            "Identical",
            "Sharpening",
            "Shifted Left by 1",
            "Shifted Right by 1",
            "Sobel Horizontal Edge",
            "Sobel Vertical Edge",
            "Edge Detection 1",
            "Edge Detection 2",
            "Edge Detection 3"});
            this.Filter_ComboBox.Location = new System.Drawing.Point(6, 11);
            this.Filter_ComboBox.Name = "Filter_ComboBox";
            this.Filter_ComboBox.Size = new System.Drawing.Size(112, 21);
            this.Filter_ComboBox.TabIndex = 0;
            // 
            // Load_Image_openFileDialog1
            // 
            this.Load_Image_openFileDialog1.FileName = "Load Image openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Threshold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Threshold_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Contrast";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Contrast_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "Histogram";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // Histogram_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Histogram_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Histogram_Chart.Legends.Add(legend1);
            this.Histogram_Chart.Location = new System.Drawing.Point(911, 19);
            this.Histogram_Chart.Name = "Histogram_Chart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Histogram_Chart.Series.Add(series1);
            this.Histogram_Chart.Size = new System.Drawing.Size(405, 253);
            this.Histogram_Chart.TabIndex = 14;
            this.Histogram_Chart.Text = "chart1";
            // 
            // B_Textbox
            // 
            this.B_Textbox.Location = new System.Drawing.Point(7, 16);
            this.B_Textbox.Name = "B_Textbox";
            this.B_Textbox.Size = new System.Drawing.Size(64, 20);
            this.B_Textbox.TabIndex = 16;
            this.B_Textbox.Text = "5";
            // 
            // Threshold_Textbox
            // 
            this.Threshold_Textbox.Location = new System.Drawing.Point(7, 17);
            this.Threshold_Textbox.Name = "Threshold_Textbox";
            this.Threshold_Textbox.Size = new System.Drawing.Size(64, 20);
            this.Threshold_Textbox.TabIndex = 17;
            this.Threshold_Textbox.Text = "50";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.B_Textbox);
            this.groupBox4.Location = new System.Drawing.Point(341, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(77, 45);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "B";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Threshold_Textbox);
            this.groupBox5.Location = new System.Drawing.Point(341, 71);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(77, 45);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Threshold";
            // 
            // Harris_Button
            // 
            this.Harris_Button.Location = new System.Drawing.Point(472, 251);
            this.Harris_Button.Name = "Harris_Button";
            this.Harris_Button.Size = new System.Drawing.Size(90, 32);
            this.Harris_Button.TabIndex = 20;
            this.Harris_Button.Text = "Harris";
            this.Harris_Button.UseVisualStyleBackColor = true;
            this.Harris_Button.Click += new System.EventHandler(this.Harris_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 573);
            this.Controls.Add(this.Load_Image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Max_Pixel_Value_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Harris_Button);
            this.Controls.Add(this.Min_Pixel_Value_Textbox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Histogram_Chart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filter_Button);
            this.Name = "Form1";
            this.Text = "Computer Vision";
            ((System.ComponentModel.ISupportInitialize)(this.Loaded_Image_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Generated_Image_PictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Histogram_Chart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_Image;
        private System.Windows.Forms.PictureBox Loaded_Image_PictureBox;
        private System.Windows.Forms.PictureBox Generated_Image_PictureBox;
        private System.Windows.Forms.Button Filter_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Filter_ComboBox;
        private System.Windows.Forms.OpenFileDialog Load_Image_openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Min_Pixel_Value_Textbox;
        private System.Windows.Forms.TextBox Max_Pixel_Value_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histogram_Chart;
        private System.Windows.Forms.TextBox B_Textbox;
        private System.Windows.Forms.TextBox Threshold_Textbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Harris_Button;
    }
}

