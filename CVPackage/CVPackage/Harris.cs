using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVPackage
{
    class Harris
    {
        public static Bitmap Apply_Harris(Bitmap image)
        {
            Filter filter = new Filter();
            Bitmap horizontal_sobel_image = filter.Apply_Sobel_Horizontal_Edge_Filter((Bitmap)image.Clone());
            Bitmap vertical_sobel_image = filter.Apply_Sobel_Vertical_Edge_Filter((Bitmap)image.Clone());

            int[,] Ix2 = new int[horizontal_sobel_image.Height, horizontal_sobel_image.Width];
            int[,] Iy2 = new int[horizontal_sobel_image.Height, horizontal_sobel_image.Width];
            int[,] Ixy = new int[horizontal_sobel_image.Height, horizontal_sobel_image.Width];

            for (int i = 0; i < horizontal_sobel_image.Height; i++)
            {
                for (int j = 0; j < horizontal_sobel_image.Width; j++)
                {
                    Ix2[i, j] = (int)Math.Pow(horizontal_sobel_image.GetPixel(j, i).R, 2);
                    Iy2[i, j] = (int)Math.Pow(vertical_sobel_image.GetPixel(j, i).R, 2);
                    Ixy[i, j] = horizontal_sobel_image.GetPixel(j, i).R * vertical_sobel_image.GetPixel(j, i).R;
                }
            }

            filter.Apply_Gaussian_7x7_Filter(Ix2, Iy2, Ixy);

            int height = Ix2.GetLength(0), width = Ix2.GetLength(1);
            int[,] result = new int[height, width];
            int[,] R = new int[height, width];
            int Rmax = 0;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int Ix2_pixel = Ix2[i, j], Iy2_pixel = Iy2[i, j], Ixy_pixel = Ixy[i, j];
                    int det = Ix2_pixel * Iy2_pixel - Ixy_pixel * Ixy_pixel;
                    int trace = Ix2_pixel + Iy2_pixel;
                    R[i, j] = det - (int)(0.01 * Math.Pow(trace, 2));
                    if (R[i, j] > Rmax)
                        Rmax = R[i, j];
                }
            }
            int cnt = 0;
            for (int i = 1; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    if (R[i, j] > .01 * Rmax && R[i, j] > R[i - 1, j - 1] && R[i, j] > R[i - 1, j] && R[i, j] > R[i - 1, j + 1] && R[i, j] > R[i, j - 1] && R[i, j] > R[i, j + 1] && R[i, j] > R[i + 1, j - 1] && R[i, j] > R[i + 1, j] && R[i, j] > R[i + 1, j + 1])
                    {
                        result[i, j] = 255;
                        cnt++;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    image.SetPixel(j, i, Color.FromArgb(result[i, j], 0, 0));
                }
            }

            return image;
        }
    }
}
