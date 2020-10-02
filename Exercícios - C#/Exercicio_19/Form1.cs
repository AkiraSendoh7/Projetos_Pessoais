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

        private void cmd_confirmar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;

            string resultado = nome.Replace(",", " ");

            txt_resultados.AppendText("Nome formatado: " + resultado + Environment.NewLine);

            txt_nome.Text = "";
        }
    }
}
