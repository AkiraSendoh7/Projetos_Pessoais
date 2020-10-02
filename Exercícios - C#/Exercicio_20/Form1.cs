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
            string frase = txt_frase.Text.ToLower();
            string letra = txt_letra.Text.ToLower();

            int contador = 0;
            foreach (char letra1 in frase)
            {
                if (letra == letra1.ToString())
                    contador++;
            }

            txt_resultados.AppendText("O número de vezes é igual a : " + contador + Environment.NewLine);

            txt_frase.Text = "";
            txt_letra.Text = "";
        }
    }
}
