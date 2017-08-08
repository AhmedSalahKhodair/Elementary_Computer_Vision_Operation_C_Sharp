using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVPackage
{
    class Contrast
    {
        public static void Apply_Contrast(Bitmap image, int B, byte min_pixel_value, byte max_pixel_value)
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    double r = image.GetPixel(j, i).R;
                    int s = (int)Math.Ceiling((Math.Pow(2, B) - 1) * ((r - min_pixel_value) / max_pixel_value - min_pixel_value));
                    s = Math.Max(s, 0);
                    s = Math.Min(s, 255);
                    image.SetPixel(j, i, Color.FromArgb(s, s, s));
                }
            }
        }

    }
}
