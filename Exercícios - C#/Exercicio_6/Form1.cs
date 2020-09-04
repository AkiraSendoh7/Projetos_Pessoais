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
            try
            {
                int dia = int.Parse(txt_dia.Text);
                int mes = int.Parse(txt_mes.Text);
                int ano = int.Parse(txt_ano.Text);
                string cidade = "São José dos Campos";
                string de = " de ";

                DateTime data = new DateTime(ano, mes, dia);
                DayOfWeek dia_da_semana = new DayOfWeek();

                dia_da_semana = data.DayOfWeek;
                int num_dia = (int)data.DayOfWeek;
                int num_mes = (int)data.Month;

                string semana = "";
                switch (num_dia)
                {
                    case 0:
                        semana = "domingo";
                        break;

                    case 1:
                        semana = "segunda-feira";
                        break;

                    case 2:
                        semana = "terça-feira";
                        break;

                    case 3:
                        semana = "quarta-feira";
                        break;

                    case 4:
                        semana = "quinta-feira";
                        break;

                    case 5:
                        semana = "sexta-feira";
                        break;

                    case 6:
                        semana = "Sábado";
                        break;
                }

                string nome_mes = "";
                switch (num_mes)
                {
                    case 1:
                        nome_mes = "janeiro";
                        break;
                    case 2:
                        nome_mes = "fevereiro";
                        break;
                    case 3:
                        nome_mes = "março";
                        break;
                    case 4:
                        nome_mes = "abril";
                        break;
                    case 5:
                        nome_mes = "maio";
                        break;
                    case 6:
                        nome_mes = "junho";
                        break;
                    case 7:
                        nome_mes = "julho";
                        break;
                    case 8:
                        nome_mes = "agosto";
                        break;
                    case 9:
                        nome_mes = "setembro";
                        break;
                    case 10:
                        nome_mes = "outubro";
                        break;
                    case 11:
                        nome_mes = "novembro";
                        break;
                    case 12:
                        nome_mes = "dezembro";
                        break;
                }

                txt_result.AppendText(cidade + ", " + semana + de + dia + de + nome_mes + de + ano + Environment.NewLine);
            }

            catch (FormatException)
            {
                MessageBox.Show("Formato inválido. Tente novamente ");
            }

            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu! Tente novamente ");
            }
        }
    }
}

