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

        //Retorna um valor int e conta o numero de vogais de uma frase qualquer
        public static int NumeroDeVogais(string frase)
        {
            int contador_vogal = 0;
            string vogais = "aeiou";

            //Um loop que tem seu valor i menor do que o comprimento da frase
            for (int i = 0; i < frase.Length; i++)
            {
                //Um loop que tem seu valor i menor que o numero de vogais 
                for (int j = 0; j < vogais.Length; j++)
                {
                    //Se a frase na posição i tiver o mesmo valor que a vogal na posicao j, então o número de vogais tem seu valor aumentado
                    if (frase[i] == vogais[j])
                    {
                        contador_vogal++;
                    }
                }
            }

            //Retorna o valor do número de vogais  
            return contador_vogal;
        }

        //Retorna um valor int e conta o numero de consoantes de uma frase qualquer
        public static int NumeroDeConsoantes(string frase)
        {
            int contador_consoante = 0;
            string consoantes = "bcdfghjklmnpqrstvwxyz";

            //Um loop que tem seu valor i menor do que o comprimento da frase
            for (int i = 0; i < frase.Length; i++)
            {
                //Um loop que tem seu valor i menor que o numero de vogais 
                for (int j = 0; j < consoantes.Length; j++)
                {
                    //Se a frase na posição i tiver o mesmo valor que a consoante na posicao j, então o número de consoante tem seu valor aumentado
                    if (frase[i] == consoantes[j])
                    {
                        contador_consoante++;
                    }
                }
            }

            //Retorna o valor de número de consoantes
            return contador_consoante;
        }

        private void cmd_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string frase = (txt_frase.Text).ToLower();

                //Adiciona a textbox o número de vogais
                txt_resultados.AppendText("Frase: " + frase + Environment.NewLine + "A palavra possuí " + NumeroDeVogais(frase) + " vogais!" + Environment.NewLine);

                //Adiciona a textbox o número de consoantes
                txt_resultados.AppendText("A palavra possui " + NumeroDeConsoantes(frase) + " consoantes!" + Environment.NewLine + Environment.NewLine);
            }

            //Caso ocorra um erro de formatação, uma MessageBox é enviada com o erro
            catch (Exception erro)
            {
                MessageBox.Show("Um erro foi capturado: \n" + erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_frase_TextChanged(object sender, EventArgs e)
        {
            //Bloquear a entrada de números na textbox
            int saida;
            bool IsNumber = false;

            IsNumber = int.TryParse(txt_frase.Text, out saida);
            if (IsNumber)
                txt_frase.Text = null;
        }
    }
}
