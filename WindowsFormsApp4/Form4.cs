using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int NSD(out int cislo1, out int cislo2)
        {
            cislo1 = int.Parse(textBox2.Text);
            cislo2 = int.Parse(textBox1.Text);
            int nsd = 1;
            int pomocna;
            if(cislo2 < cislo1)
            {
                pomocna = cislo2;
                cislo2 = cislo1;
                cislo1 = pomocna;
            }
            for (int i = 1; i <= cislo1; i++)
            {
                if (cislo1 % i == 0 && cislo2 % i == 0)
                    nsd = i;
            }
            return nsd;
        }
        int NSN(out int cislo1, out int cislo2)
        {
            cislo1 = int.Parse(textBox2.Text);
            cislo2 = int.Parse(textBox1.Text);

            return nsn;
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            int cislo1;
            int cislo2;
            label2.Text = "NSD:" + NSD(out cislo1, out cislo2).ToString();
            label3.Text = "NSN:" + NSN(out cislo1, out cislo2).ToString();
        }
    }
}
