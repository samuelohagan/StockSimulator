using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meta.Numerics;
using Meta.Numerics.Statistics.Distributions;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;

namespace montecarloform
{

    public partial class 
        
        
        Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
           

            

        }
        public static double Percentile(IEnumerable<double> seq, double percentile)
        {
            var elements = seq.ToArray();
            Array.Sort(elements);
            double realIndex = percentile * (elements.Length - 1);
            int index = (int)realIndex;
            double frac = realIndex - index;
            if (index + 1 < elements.Length)
                return elements[index] * (1 - frac) + elements[index + 1] * frac;
            else
                return elements[index];
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();

      
            double[] ab = new double[30];
            double[] page = new double[30];
            double[] sabc = new double[30];
            double[] derp = new double[31];
            
            Random rnd = new Random();
            double[] randomdouble = new double[30];
            Series series = this.chart1.Series.Add("a");
            chart1.Series["a"].ChartType = SeriesChartType.Line;
            for (int i = 0; i < page.Length; ++i)
            {
                page[i] = rnd.Next(101, 9999);
                randomdouble[i] = (double)page[i] / (double)10000;
                double mean = Convert.ToDouble(myTextBox2.Text);
                double stdev = Convert.ToDouble(myTextBox3.Text);
                Distribution n = new NormalDistribution(mean, stdev);
                double b = n.InverseLeftProbability(randomdouble[i]);
                double x = ((double)b / (double)100) + 1;
                
                sabc[i] = x;
                derp[0] = Convert.ToDouble(myTextBox.Text);

                derp[i + 1] = (double)x * (double)derp[i];                                             
                Console.WriteLine(x);
                // Add point.
                series.Points.Add(derp[i]);
            }
            
            double[] k = new double[1001];
            for (int deh = 0; deh < k.Length; ++deh)
            {
                for (int i = 0; i < page.Length; ++i)
                {
                    page[i] = rnd.Next(101, 9999);
                    randomdouble[i] = (double)page[i] / (double)10000;
                    double mean = Convert.ToDouble(myTextBox2.Text);
                    double stdev = Convert.ToDouble(myTextBox3.Text);
                    Distribution n = new NormalDistribution(mean, stdev);
                    double b = n.InverseLeftProbability(randomdouble[i]);
                    double x = ((double)b / (double)100) + 1;

                    sabc[i] = x;
                    derp[0] = Convert.ToDouble(myTextBox.Text);

                    derp[i + 1] = (double)x * (double)derp[i];
                    
                    // Add point.
                    
                }
                k[deh] = derp[29];
                //Console.WriteLine(k[deh]);
                




             }
            //90% chance that the price will be greater then this
            label90.Text = Convert.ToString(Percentile(k, 0.10));
            //75% chance that the price will be greater then this
            label75.Text = Convert.ToString(Percentile(k, 0.25));
            //50% chance that the price will be greater then this
            label50.Text = Convert.ToString(Percentile(k, 0.50));
            //25% chance that the price will be greater then this
            label25.Text = Convert.ToString(Percentile(k, 0.75));

        }
        public void ResetForm()
        {
            Random rnd = new Random();
            chart1.Series.Clear();
           



            
        }
    }
}
