using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CVPackage
{
    class Threshold
    {
        public static void Apply_Threshold(Bitmap image,int threshold)
        {
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    if (image.GetPixel(j, i).R < threshold)
                        image.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    else
                        image.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                }
            }


        }
    }
}
