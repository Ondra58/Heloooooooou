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
        bool JePrvocislo(out int vstup)
        {
            vstup = int.Parse(textBox2.Text);
            bool prvocislo = false;
            if (vstup == 2 || vstup == 3)
            {
                prvocislo = true;
            }
            else if (vstup % 2 == 0 && vstup != 2 || vstup == 1)
            {
                prvocislo = false;
            }
            else
            {
                prvocislo = true;
                for (int i = 3; i <= Math.Sqrt(vstup) && prvocislo != false; i += 2)
                {
                    if (vstup % i == 0)
                    {
                        prvocislo = false;
                    }
                    else
                    {
                        prvocislo = true;
                    }
                }
            }
            return prvocislo;
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
                {
                    nsd = i;
                }
            }
            return nsd;
        }
        int NSN(out int cislo1, out int cislo2)
        {
            cislo1 = int.Parse(textBox2.Text);
            cislo2 = int.Parse(textBox1.Text);
            int pomocna;
            if (cislo2 < cislo1)
            {
                pomocna = cislo2;
                cislo2 = cislo1;
                cislo1 = pomocna;
            }
            for (int i = 1; i <= cislo1; i++)
            {
                    pomocna = cislo1 * i;
                    if(pomocna % cislo2 == 0)
                    {
                        return pomocna;
                    }
            }
            return cislo1 * cislo2;
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            int cislo1;
            int cislo2;
            int vstup;
            label2.Text = "NSD:" + NSD(out cislo1, out cislo2).ToString();
            label3.Text = "NSN:" + NSN(out cislo1, out cislo2).ToString();
            if(JePrvocislo(out vstup) == true)
            {
                label4.Text = "Číslo 1 je prvočíslo";
            }
            else
            {
                label4.Text = "Číslo 1 není prvočíslo";
            }
            
        }
    }
}
