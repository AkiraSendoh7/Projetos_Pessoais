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
            txtNome.Focus();
        }

        private void cmd_confirma_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            decimal valoratual = (((Convert.ToDecimal(txt_taxa.Text) / 100) * valor) + valor);

            decimal xvalor = Convert.ToDecimal(string.Format("{0:#.00}", valor));
            decimal xvaloratual = Convert.ToDecimal(string.Format("{0:#.00}", valoratual));

            lstnome.Items.Add(nome);
            lstvalorinicial.Items.Add(xvalor);
            lstvaloratual.Items.Add(xvaloratual);

            txtNome.Text = "";
            txtValor.Text = "";
            txt_taxa.Text = "";

            txtNome.Focus();
        }
    }
}
