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

namespace Exercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                string frase = (txt_frase.Text);

                //Retira os espaços iniciais da frase, caso houver 
                string formata_frase = frase.TrimStart();

                //Retira o primeiro caractere da frase 
                string oracao = Convert.ToString(formata_frase[0]);

                //Retira o valor booleano caso a variável comece com letra maiúscula
                bool res = oracao.StartsWith(oracao.ToUpper());

                switch (res)
                {
                    case true:
                        txt_resultados.AppendText(frase + Environment.NewLine);

                        break;

                    case false:

                        for (int i = 0; i < formata_frase.Length; i++)
                        {
                            if (i == 0)
                                txt_resultados.AppendText(oracao.ToUpper());
                            else
                                txt_resultados.AppendText(Convert.ToString(formata_frase[i]));
                        }

                        txt_resultados.AppendText(Environment.NewLine);

                        break;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(" Erro: \n\n" + erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
