using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVPackage
{
    class Filter
    {
        float[,] average_filter;
        float[,] identical_filter;
        float[,] shifted_left_by_1_filter;
        float[,] shifted_right_by_1_filter;
        float[,] sharpening_filter;
        float[,] sobel_vertical_edge_filter;
        float[,] sobel_horizontal_edge_filter;
        float[,] edge_detection_1_filter;
        float[,] edge_detection_2_filter;
        float[,] edge_detection_3_filter;
        float[,] gaussian_filter;
        float[,] gaussian_filter1;
        float[,] selected_filter;
        Bitmap image;
        public Filter()
        {
            average_filter_initializer();
            identical_filter_initializer();
            shifted_left_by_1_filter_initializer();
            shifted_right_by_1_filter_initializer();
            sharpening_filter_initializer();
            sobel_vertical_edge_filter_initializer();
            sobel_horizontal_edge_filter_initializer();
            edge_detection_1_filter_initializer();
            edge_detection_2_filter_initializer();
            edge_detection_3_filter_initializer();
            gaussian_7x7_filter_initializer();
        }
        void average_filter_initializer()
        {
            average_filter = new float[3, 3]
            {
                {(float)1/9,(float)1/9,(float)1/9},
                {(float)1/9,(float)1/9,(float)1/9},
                {(float)1/9,(float)1/9,(float)1/9}
            };
        }
        void identical_filter_initializer()
        {
            identical_filter = new float[3, 3]
            {
                {(float)0,(float)0,(float)0},
                {(float)0,(float)1,(float)0},
                {(float)0,(float)0,(float)0}
            };
        }
        void shifted_left_by_1_filter_initializer()
        {
            // fe el mo7adra el 1 3l shemal , we tal3a 8lt el mafrod , fe paper tanya el 1 3l yemen fe3ln we tal3a sa7
            shifted_left_by_1_filter = new float[3, 3]
            {
                {(float)0,(float)0,(float)0},
                {(float)0,(float)0,(float)1},
                {(float)0,(float)0,(float)0}
            };
        }
        void shifted_right_by_1_filter_initializer()
        {
            shifted_right_by_1_filter = new float[3, 3]
            {
                {(float)0,(float)0,(float)0},
                {(float)1,(float)0,(float)0},
                {(float)0,(float)0,(float)0}
            };
        }
        void sharpening_filter_initializer()
        {
            sharpening_filter = new float[3, 3]
            {
                {(float)0,(float)-1,(float)0},
                {(float)-1,(float)5,(float)-1},
                {(float)0,(float)-1,(float)0}
            };
        }
        void sobel_vertical_edge_filter_initializer()
        {
            sobel_vertical_edge_filter = new float[3, 3]
            {
                {(float)1,(float)0,(float)-1},
                {(float)2,(float)0,(float)-2},
                {(float)1,(float)0,(float)-1}
            };
        }
        void sobel_horizontal_edge_filter_initializer()
        {
            sobel_horizontal_edge_filter = new float[3, 3]
            {
                {(float)1,(float)2,(float)1},
                {(float)0,(float)0,(float)0},
                {(float)-1,(float)-2,(float)-1}
            };
        }
        void edge_detection_1_filter_initializer()
        {
            edge_detection_1_filter = new float[3, 3]
            {
                {(float)1,(float)0,(float)-1},
                {(float)0,(float)0,(float)0},
                {(float)-1,(float)0,(float)1}
            };
        }
        void edge_detection_2_filter_initializer()
        {
            edge_detection_2_filter = new float[3, 3]
            {
                {(float)0,(float)1,(float)0},
                {(float)1,(float)-4,(float)1},
                {(float)0,(float)1,(float)0}
            };
        }
        void edge_detection_3_filter_initializer()
        {
            edge_detection_3_filter = new float[3, 3]
            {
                {(float)-1,(float)-1,(float)-1},
                {(float)-1,(float)8,(float)-1},
                {(float)-1,(float)-1,(float)-1}
            };
        }
        void gaussian_7x7_filter_initializer()
        {
            gaussian_filter1 = new float[7, 7]
            {
                {0.000036f  ,  0.000363f  ,  0.001446f  ,  0.002291f  ,  0.001446f  ,  0.000363f  ,  0.000036f},
                {0.000363f  ,  0.003676f  ,  0.014662f  ,  0.023226f  ,  0.014662f  ,  0.003676f  ,  0.000363f},
                {0.001446f  ,  0.014662f  ,  0.058488f  ,  0.092651f  ,  0.058488f  ,  0.014662f  ,  0.001446f},
                {0.002291f  ,  0.023226f  ,  0.092651f  ,  0.146768f  ,  0.092651f  ,  0.023226f  ,  0.002291f},
                {0.001446f  ,  0.014662f  ,  0.058488f  ,  0.092651f  ,  0.058488f  ,  0.014662f  ,  0.001446f},
                {0.000363f  ,  0.003676f  ,  0.014662f  ,  0.023226f  ,  0.014662f  ,  0.003676f  ,  0.000363f},
                {0.000036f  ,  0.000363f  ,  0.001446f  ,  0.002291f  ,  0.001446f  ,  0.000363f  ,  0.000036f}
            };
            gaussian_filter = new float[7, 7]
            {
                {0.0001f  ,  0.0015f  ,  0.0067f  ,  0.0111f  ,  0.0067f  ,  0.0015f  ,  0.0001f},
                {0.0015f  ,  0.0183f  ,  0.0821f  ,  0.1353f  ,  0.0821f  ,  0.0183f  ,  0.0015f},
                {0.0067f  ,  0.0821f  ,  0.3679f  ,  0.6065f  ,  0.3679f  ,  0.0821f  ,  0.0067f},
                {0.0111f  ,  0.1352f  ,  0.6065f  ,  1.0000f  ,  0.6065f  ,  0.1352f  ,  0.0111f},
                {0.0067f  ,  0.0821f  ,  0.3679f  ,  0.6065f  ,  0.3679f  ,  0.0821f  ,  0.0067f},
                {0.0015f  ,  0.0183f  ,  0.0821f  ,  0.1353f  ,  0.0821f  ,  0.0183f  ,  0.0015f},
                {0.0001f  ,  0.0015f  ,  0.0067f  ,  0.0111f  ,  0.0067f  ,  0.0015f  ,  0.0001f}
            };
        }
        void Apply_Selected_Filter()
        {
            Bitmap tmp_image = new Bitmap(image.Width + average_filter.GetLength(0) - 1, image.Height + average_filter.GetLength(1) - 1);// zero padded image
            #region copy image with zero-padding
            for (int i = 0; i < tmp_image.Height; i++)
            {
                for (int j = 0; j < tmp_image.Width; j++)
                {
                    //law fe awl aw a5r row/coloumn y5le el value be zero
                    if (i < average_filter.GetLength(0) / 2 || i >= tmp_image.Height - average_filter.GetLength(0) / 2 || j < average_filter.GetLength(1) / 2 || j >= tmp_image.Width - average_filter.GetLength(1) / 2)
                        tmp_image.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    else                        // law kernel 7x7 yeb2a 3 , 5x5 yeb2a 2 , 3x3 yeb2a 1
                        tmp_image.SetPixel(j, i, image.GetPixel(j - average_filter.GetLength(0) / 2, i - average_filter.GetLength(1) / 2));
                }
            }
            #endregion
            #region slide filter over image
            for (int i = average_filter.GetLength(0) / 2; i < tmp_image.Height - average_filter.GetLength(0) / 2; i++)
            {
                for (int j = average_filter.GetLength(1) / 2; j < tmp_image.Width - average_filter.GetLength(1) / 2; j++)
                {
                    float red = 0, green = 0, blue = 0;               // loop to do
                    for (int ki = 0; ki < selected_filter.GetLength(0); ki++)
                    {
                        for (int kj = 0; kj < selected_filter.GetLength(1); kj++)
                        {
                            red += selected_filter[ki, kj] * tmp_image.GetPixel(kj + j - selected_filter.GetLength(1) / 2, ki + i - selected_filter.GetLength(0) / 2).R;
                            green += selected_filter[ki, kj] * tmp_image.GetPixel(kj + j - selected_filter.GetLength(1) / 2, ki + i - selected_filter.GetLength(0) / 2).G;
                            blue += selected_filter[ki, kj] * tmp_image.GetPixel(kj + j - selected_filter.GetLength(1) / 2, ki + i - selected_filter.GetLength(0) / 2).B;
                        }
                    }
                    red = Math.Max(red, 0); green = Math.Max(green, 0); blue = Math.Max(blue, 0);
                    red = Math.Min(red, 255); green = Math.Min(green, 255); blue = Math.Min(blue, 255);
                    image.SetPixel(j - average_filter.GetLength(1) / 2, i - average_filter.GetLength(0) / 2, Color.FromArgb((int)red, (int)green, (int)blue));
                }
            }
            #endregion
        }
        public Bitmap Apply_Average_Filter(Bitmap image1)
        {
            selected_filter = average_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Identical_Filter(Bitmap image1)
        {
            selected_filter = identical_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Shifted_Left_By_1_Filter(Bitmap image1)
        {
            selected_filter = shifted_left_by_1_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Shifted_Right_By_1_Filter(Bitmap image1)
        {
            selected_filter = shifted_right_by_1_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Sharpening_Filter(Bitmap image1)
        {
            selected_filter = sharpening_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Sobel_Vertical_Edge_Filter(Bitmap image1)
        {
            selected_filter = sobel_vertical_edge_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Sobel_Horizontal_Edge_Filter(Bitmap image1)
        {
            selected_filter = sobel_horizontal_edge_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Edge_Detection_1_Filter(Bitmap image1)
        {
            selected_filter = edge_detection_1_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Edge_Detection_2_Filter(Bitmap image1)
        {
            selected_filter = edge_detection_2_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public Bitmap Apply_Edge_Detection_3_Filter(Bitmap image1)
        {
            selected_filter = edge_detection_3_filter;
            image = image1;
            Apply_Selected_Filter();
            return image;
        }
        public void Apply_Gaussian_7x7_Filter(int[,] Ix2, int[,] Iy2, int[,] Ixy)
        {
            selected_filter = gaussian_filter;
            apply_gaussian_filter(Ix2, Iy2, Ixy);
        }
        void apply_gaussian_filter(int[,] Ix2, int[,] Iy2, int[,] Ixy)
        {
            int[,] Ix2_tmp = new int[Ix2.GetLength(0) + selected_filter.GetLength(0) - 1, Ix2.GetLength(1) + selected_filter.GetLength(1) - 1];// zero padded image
            int[,] Iy2_tmp = new int[Ix2.GetLength(0) + selected_filter.GetLength(0) - 1, Ix2.GetLength(1) + selected_filter.GetLength(1) - 1];// zero padded image
            int[,] Ixy_tmp = new int[Ix2.GetLength(0) + selected_filter.GetLength(0) - 1, Ix2.GetLength(1) + selected_filter.GetLength(1) - 1];// zero padded image

            #region copy image with zero-padding
            for (int i = 0; i < Ix2_tmp.GetLength(0); i++)
            {
                for (int j = 0; j < Ix2_tmp.GetLength(1); j++)
                {
                    //law fe awl aw a5r row/coloumn y5le el value be zero
                    if (i < selected_filter.GetLength(0) / 2 || i >= Ix2_tmp.GetLength(0) - selected_filter.GetLength(0) / 2 || j < selected_filter.GetLength(1) / 2 || j >= Ix2_tmp.GetLength(1) - selected_filter.GetLength(1) / 2)
                    {
                        Ix2_tmp[i, j] = 0;
                        Iy2_tmp[i, j] = 0;
                        Ixy_tmp[i, j] = 0;
                    }
                    else
                    {
                        Ix2_tmp[i, j] = Ix2[i - selected_filter.GetLength(0) / 2, j - selected_filter.GetLength(1) / 2];
                        Iy2_tmp[i, j] = Iy2[i - selected_filter.GetLength(0) / 2, j - selected_filter.GetLength(1) / 2];
                        Ixy_tmp[i, j] = Ixy[i - selected_filter.GetLength(0) / 2, j - selected_filter.GetLength(1) / 2];
                    }
                }
            }
            #endregion
            #region slide filter over image
            for (int i = selected_filter.GetLength(0) / 2; i < Ix2.GetLength(0) - selected_filter.GetLength(0) / 2; i++)
            {
                for (int j = selected_filter.GetLength(1) / 2; j < Ix2.GetLength(1) - selected_filter.GetLength(1) / 2; j++)
                {
                    double Ix2_value = 0, Iy2_value = 0, Ixy_value = 0;
                    for (int ki = 0; ki < selected_filter.GetLength(0); ki++)
                    {
                        for (int kj = 0; kj < selected_filter.GetLength(1); kj++)
                        {
                            Ix2_value += selected_filter[ki, kj] * Ix2_tmp[ki + i - selected_filter.GetLength(0) / 2, kj + j - selected_filter.GetLength(1) / 2];
                            Iy2_value += selected_filter[ki, kj] * Iy2_tmp[ki + i - selected_filter.GetLength(0) / 2, kj + j - selected_filter.GetLength(1) / 2];
                            Ixy_value += selected_filter[ki, kj] * Ixy_tmp[ki + i - selected_filter.GetLength(0) / 2, kj + j - selected_filter.GetLength(1) / 2];
                        }
                    }
                    Ix2[i, j] = (int)Ix2_value;
                    Iy2[i, j] = (int)Iy2_value;
                    Ixy[i, j] = (int)Ixy_value;
                }
            }
            #endregion
        }

    }
}