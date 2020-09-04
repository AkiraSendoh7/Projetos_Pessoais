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

        private void cmd_confirma_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int Dia = int.Parse(txtDia.Text);
            int Mes = int.Parse(txtMes.Text);
            int Ano = int.Parse(txtAno.Text);

            int ano_atual = DateTime.Now.Year;
            int idade = ano_atual - Ano;
            int numero = Dia + 2 * Mes + (3 * (Mes + 1)) / 5 + Ano + Ano / 4 - Ano / 100 + Ano / 400 + 2;


            string Dia_semana = Convert.ToString(numero % 7);


            //Função if para os dias da semana 
            if (int.Parse(Dia_semana) == 0)
            {
                Dia_semana = "Sábado";
            }
            else if (int.Parse(Dia_semana) == 1)
            {
                Dia_semana = "Domingo";
            }
            else if (int.Parse(Dia_semana) == 2)
            {
                Dia_semana = "Segunda-feira";
            }
            else if (int.Parse(Dia_semana) == 3)
            {
                Dia_semana = "Terça-feira";
            }
            else if (int.Parse(Dia_semana) == 4)
            {
                Dia_semana = "Quarta-feira";
            }
            else if (int.Parse(Dia_semana) == 5)
            {
                Dia_semana = "Quinta-feira";
            }
            else
            {
                Dia_semana = "Sexta-feira";
            }


            txtR.Text = txtR.Text + Convert.ToString(nome + ", " + idade + ", " + Dia_semana) + Environment.NewLine;
        }
    }
}
