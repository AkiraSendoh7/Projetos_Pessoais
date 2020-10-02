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

        public static string ReverteString (string nome)
        {
            var frase_formatada = new string(nome.ToCharArray().Reverse().ToArray()); 

            return frase_formatada;
        }

        private void txt_frase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                lbl_resultados.Visible = true;
                lbl_resultados.Text = ReverteString(txt_frase.Text);

                txt_frase.Text = null;
            }
        }
    }
}
