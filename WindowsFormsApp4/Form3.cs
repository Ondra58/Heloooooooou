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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string Cislice(out string vstup)
        {
            vstup = textBox1.Text;
            foreach (char znak in textBox1.Text)
            {
                if ((int)znak >= 48 && (int)znak <= 57)
                {
                    vstup = vstup.Replace(znak.ToString(), "");
                }
            }
            while (vstup.Contains("  "))
            {
                vstup = vstup.Replace("  ", " ");
            }
            vstup = vstup.Trim();
            return vstup;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string vstup;
            Cislice(out vstup);
            string[] slova = vstup.Split(' ');
            foreach(string slovo in slova)
            {
                listBox1.Items.Add(slovo);
            }
        }
    }
}
