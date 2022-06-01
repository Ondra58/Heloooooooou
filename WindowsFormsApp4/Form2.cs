using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool JeAlfanum(string vstup, ref bool alfanum, ref int male, ref int velke, ref int jine, ref int pocet)
        {
            vstup = textBox1.Text;
            alfanum = true;
            male = 0;
            velke = 0;
            jine = 0;
            pocet = 0;
            foreach (char znak in textBox1.Text)
            {
                if((int)znak >= 97 && ((int)znak <= 122))
                {
                    male++;
                }
                if ((int)znak >= 65 && ((int)znak <= 90))
                {
                    velke++;
                }
                if ((int)znak < 48 || ((int)znak > 57) && ((int)znak < 65) || ((int)znak > 90) && ((int)znak < 97) || (int)znak > 122)
                {
                    alfanum = false;
                    jine++;
                }
                pocet++;
            }
            return alfanum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            bool alfanum = true;
            int male = 0;
            int velke = 0;
            int jine = 0;
            int pocet = 0;
            JeAlfanum(vstup, ref alfanum, ref male, ref velke, ref jine, ref pocet);
            if (pocet == 0)
            {
                label1.Text = "Text neobsahuje žádné znaky";
            }
            else
            {
                if (alfanum)
                {
                    label1.Text = "Text je alfanumerický";
                }
                else
                {
                    label1.Text = "Text není alfanumerický";
                }
            }           
            label2.Text = "Počet malých písmen: " + male.ToString();
            label3.Text = "Počet velkých písmen: " + velke.ToString();
            label4.Text = "Počet jiných znaků: " + jine.ToString();
        }
    }
}
