//Feito por AkiraSendoh7 
//https://github.com/AkiraSendoh7/Projetos_Pessoais.git
//Usar com moderação, sempre bom

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading;
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

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F5))
            {
                string nome = txt_nome.Text;

                string formata_nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

                txt_resultados.AppendText("Nome: " + formata_nome + Environment.NewLine);

                txt_nome.Text = null;
            }
        }
    }
}
