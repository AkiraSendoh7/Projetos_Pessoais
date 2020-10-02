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
using System.Globalization;
using System.Threading;
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
            string formata_data = msk_dia.Text;
            int dia = int.Parse(formata_data.Substring(0, 2));
            int mes = int.Parse(formata_data.Substring(3, 2));
            int ano = int.Parse(formata_data.Substring(6, 4));

            DateTime data = new DateTime(ano, mes, dia);

            int num_dia = (int)data.DayOfWeek;

            string semana = "";
            switch (num_dia)
            {
                case 0:
                    semana = "Domingo";
                    break;

                case 1:
                    semana = "Segunda-feira";
                    break;

                case 2:
                    semana = "Terça-feira";
                    break;

                case 3:
                    semana = "Quarta-feira";
                    break;

                case 4:
                    semana = "Quinta-feira";
                    break;

                case 5:
                    semana = "Sexta-feira";
                    break;

                case 6:
                    semana = "Sábado";
                    break;
            }

            txt_resultado.AppendText("Dia da semana: " + semana + Environment.NewLine);
            msk_dia.Text = "";
        }
    }
}
