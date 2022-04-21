using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_2_řetězce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] VysledekText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 'A' && text[i] <= 'Z'))
                {
                    int znak = Convert.ToInt32(text[i]) + 32;
                    VysledekText[i] = (char)znak;
                }
                else
                {
                    VysledekText[i] = (char)text[i];
                }
            }

            string vysledek = new string(VysledekText);
            textBox1.Text = vysledek;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            text = text.Replace("*", "");
            textBox1.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
    
}
