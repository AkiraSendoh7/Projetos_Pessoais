//Feito por AkiraSendoh7 
//https://github.com/AkiraSendoh7/Projetos_Pessoais.git
//Usar com moderação, sempre bom

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double dolar = 3.50;

            string f1 = dolar.ToString("##0.00");
            string f2 = dolar.ToString("-###.00");
            string f3 = dolar.ToString("#00.00");
            string f4 = dolar.ToString("000.00");
            string f5 = dolar.ToString("000.##");
            string f6 = dolar.ToString("MMMM");
            string f7 = string.Format("{0:C1} ", dolar);
            string f8 = string.Format("{0,5} ", dolar);

            textBox1.AppendText(f1 + Environment.NewLine);
            textBox1.AppendText(f2 + Environment.NewLine);
            textBox1.AppendText(f3 + Environment.NewLine);
            textBox1.AppendText(f4 + Environment.NewLine);
            textBox1.AppendText(f5 + Environment.NewLine);
            textBox1.AppendText(f6 + Environment.NewLine);
            textBox1.AppendText(f7 + Environment.NewLine);
            textBox1.AppendText(f8 + Environment.NewLine);
        }
    }
}
