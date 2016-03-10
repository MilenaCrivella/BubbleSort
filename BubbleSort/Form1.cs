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
        private void AddNumbers(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = random.Next(1, 10);
                NumbersList.Add(n);
            }
            
            foreach (int l in NumbersList)
            {
                    Console.WriteLine(l.ToString());
            }  
        }

    }
}
