using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        List<int>NumbersList = new List<int>();
        Stopwatch stopwatch = new Stopwatch();
        long time = 0;
        private void AddNumbers(object sender, EventArgs e)
        {
            Random random = new Random();
            int qtd = 500;
            while (NumbersList.Count < 2000) 
            { 
                for (int i = 0; i < qtd; i++)
                {
                    int n = random.Next(1, qtd);
                    NumbersList.Add(n);
                }
                BubbleSort();
                DrawGraphic();

            }
        }
        
        private void BubbleSort() 
        {
            stopwatch.Start();
            for (int i = 0; i < NumbersList.Count - 1; i++)
            {
                for (int j = i + 1; j < NumbersList.Count; j++)
                {
                    if (NumbersList[i] > NumbersList[j])
                    {
                        int A = NumbersList.ElementAt(i);
                        int B = NumbersList.ElementAt(j);

                        NumbersList[i] = B;
                        NumbersList[j] = A;
                    }
                }
            }
            stopwatch.Stop();
            time += stopwatch.Elapsed.Milliseconds;
        }

        private void DrawGraphic()
        {
            Graphic.Series["Series1"].Points.AddXY(NumbersList.Count, time);
        }

        public void PrintList(List<int> l)
        {
            foreach (int item in l)
            {
                //Console.Write(item.ToString());
            }
        }

    }
}
