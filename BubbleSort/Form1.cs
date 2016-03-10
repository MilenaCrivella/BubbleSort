using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int>NumbersList = new List<int>();
        int tempo = 0;
        private void AddNumbers(object sender, EventArgs e)
        {
            Random random = new Random();
            int qtd = 1000;
            for (int i = 0; i < qtd; i++)
            {
                int n = random.Next(1, qtd);
                NumbersList.Add(n);
            }
            
            foreach (int l in NumbersList)
            {
                    Console.WriteLine(l.ToString());
            }  
        }

        private void BubbleSort(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer(1);
            t.Start();
            t.Elapsed += OnTimedEvent;
            // zera time
            // start
            for (int i = 0; i < NumbersList.Count -1; i++)
            {
                for (int j = i + 1; j < NumbersList.Count; j++)
                {
                //Console.WriteLine(NumbersList.ElementAt(i) + "::" + NumbersList.ElementAt(j));
                    if (NumbersList[i] > NumbersList[j])
                    {
                        // trocar!
                        int A = NumbersList.ElementAt(i);
                        int B = NumbersList.ElementAt(j);

                        NumbersList[i] = B;
                        NumbersList[j] = A;
                        //Console.WriteLine("trocou " + i.ToString() + " com " + j.ToString());
                    }
                    //Console.WriteLine(">> " + NumbersList.ElementAt(j));
                }
                //Console.WriteLine(NumbersList.ElementAt(i));
            }
            // stop
            t.Stop();
            // save/print time
            PrintList(NumbersList);
            Console.WriteLine();
            Console.WriteLine(tempo);
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            tempo++;
        }

        public void PrintList(List<int> l)
        {
            foreach (int item in l)
            {
                Console.Write(item.ToString());
            }
        }

    }
}
