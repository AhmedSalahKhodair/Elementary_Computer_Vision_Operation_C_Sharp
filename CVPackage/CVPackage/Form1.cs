using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVPackage
{

    public partial class Form1 : Form
    {
        Bitmap input_image, output_image;
        Filter filter = new Filter();
        byte min_pixel_value = byte.MaxValue;
        byte max_pixel_value = byte.MinValue;
        public Form1()
        {
            InitializeComponent();
            Filter_ComboBox.SelectedIndex = 0;
            //Bitmap m = new Bitmap(10, 100);
            //for(int i = 0; i < 100; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //        m.SetPixel(j, i, Color.FromArgb(255, 10, 10));
            //}
            //Loaded_Image_pictureBox1.Image = m;

            //bmp.Save(@"E:\savedPic.png");
        }

        private void Load_Image_Click(object sender, EventArgs e)
        {

            DialogResult Image_Path = Load_Image_openFileDialog1.ShowDialog();
            if (Image_Path == DialogResult.OK)
            {
                try
                {
                    input_image = new Bitmap(Load_Image_openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Image Directory isn't correct");
                }
            }
            Loaded_Image_PictureBox.Image = input_image;
            output_image = new Bitmap(input_image.Width, input_image.Height);

            for (int i = 0; i < input_image.Height; i++)
            {
                for (int j = 0; j < input_image.Width; j++)
                {
                    if (input_image.GetPixel(j, i).R < min_pixel_value)
                        min_pixel_value = input_image.GetPixel(j, i).R;
                    if (input_image.GetPixel(j, i).R > max_pixel_value)
                        max_pixel_value = input_image.GetPixel(j, i).R;
                }
            }
            Min_Pixel_Value_Textbox.Text = min_pixel_value.ToString();
            Max_Pixel_Value_Textbox.Text = max_pixel_value.ToString();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (Filter_ComboBox.SelectedItem.ToString() == "Average")
                output_image = filter.Apply_Average_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Identical")
                output_image = filter.Apply_Identical_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Sharpening")
                output_image = filter.Apply_Sharpening_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Shifted Left by 1")
                output_image = filter.Apply_Shifted_Left_By_1_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Shifted Right by 1")
                output_image = filter.Apply_Shifted_Right_By_1_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Sobel Vertical Edge")
                output_image = filter.Apply_Sobel_Vertical_Edge_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Sobel Horizontal Edge")
                output_image = filter.Apply_Sobel_Horizontal_Edge_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Edge Detection 1")
                output_image = filter.Apply_Edge_Detection_1_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Edge Detection 2")
                output_image = filter.Apply_Edge_Detection_2_Filter((Bitmap)input_image.Clone());
            else if (Filter_ComboBox.SelectedItem.ToString() == "Edge Detection 3")
                output_image = filter.Apply_Edge_Detection_3_Filter((Bitmap)input_image.Clone());


            Generated_Image_PictureBox.Image = output_image;

        }

        private void Threshold_Click(object sender, EventArgs e)
        {
            output_image = (Bitmap)input_image.Clone();
            Threshold.Apply_Threshold(output_image, int.Parse(Threshold_Textbox.Text));
            Generated_Image_PictureBox.Image = output_image;
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
            output_image = (Bitmap)input_image.Clone();
            Contrast.Apply_Contrast(output_image, int.Parse(B_Textbox.Text), min_pixel_value, max_pixel_value);
            Generated_Image_PictureBox.Image = output_image;
        }

        private void Harris_Button_Click(object sender, EventArgs e)
        {
            output_image = Harris.Apply_Harris((Bitmap)input_image.Clone());
            Generated_Image_PictureBox.Image = output_image;
        }

        private void Histogram_Click(object sender, EventArgs e)
        {
            Histogram_Chart.Series.Clear();
            Histogram_Chart.Series.Add("Series1");
            Histogram.Generate_Histogram((Bitmap)input_image.Clone(), Histogram_Chart);
        }

    }
}
