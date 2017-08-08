using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CVPackage
{
    public class Histogram
    {
        public static void Generate_Histogram(Bitmap image, Chart Histogram_Chart)
        {
            int[] values_counter = new int[256];
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    values_counter[image.GetPixel(j, i).R]++;
                }
            }
            int max_instance = -1;//for y-axis max value
            for (int i = 0; i < 256; i++)
            {
                Histogram_Chart.Series["Series1"].Points.AddXY(i, values_counter[i]);
                max_instance = Math.Max(max_instance, values_counter[i]);
            }
            // tazabet
            Histogram_Chart.Series["Series1"].IsVisibleInLegend = false;//3shan el esm myzhrsh we ya5od 7ta mn el chart
            Histogram_Chart.Series["Series1"].Color = Color.DeepPink;
            Histogram_Chart.ChartAreas[0].AxisX.Minimum = -1;
            Histogram_Chart.ChartAreas[0].AxisX.Maximum = 256;
            Histogram_Chart.ChartAreas[0].AxisY.Maximum = max_instance + 10;
        }
    }
}
