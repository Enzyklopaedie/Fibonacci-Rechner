using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong neugeborene, geschlechtsreif = 1, gesamt = 1;
            ulong monat;
            monat = Convert.ToUInt64(textBox1.Text);
            for (ulong i = 1;i <= monat; i = i+1)
            {
                neugeborene = geschlechtsreif;
                geschlechtsreif = gesamt;
                gesamt = neugeborene + geschlechtsreif;
            }
            if (monat == 1)
            {
                label2.Text = "Nach einem Monat sind es insgesamt " + Convert.ToString(gesamt) + " Kaninchen.";
            }
            else
            {
                label2.Text = "Nach " + monat.ToString() + " Monaten sind es " + gesamt.ToString() + " Kaninchen.";     // gesamt.ToString() ist das gleiche wie Convert.ToString(gesamt)
            }   
        }
    }
}
