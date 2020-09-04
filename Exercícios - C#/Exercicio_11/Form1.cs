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

        private void button1_Click(object sender, EventArgs e)
        {
            double area_circulo = double.Parse(textBox1.Text);
            double raio_squared = 0.00;

            raio_squared = area_circulo / Math.PI;

            double raio = Math.Sqrt(raio_squared);
            double diametro = 2 * raio;

            MessageBox.Show("O diâmetro vale "+ diametro);

        }
    }
}
