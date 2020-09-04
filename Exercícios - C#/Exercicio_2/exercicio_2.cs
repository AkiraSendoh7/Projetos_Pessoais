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

        public void dias(string date, int a)
        {
            //Testes para saber qual dia é util ou não 
            if ((a > 0) && (a < 6))
                txt_result.AppendText("Dia: " + date + Environment.NewLine + "Esta data pertence a um dia útil" + Environment.NewLine);
            else if ((a == 0) || (a == 6))
                txt_result.AppendText("Dia: " + date + Environment.NewLine + "Esta data não pertence a um dia útil" + Environment.NewLine);
            else
                MessageBox.Show("Ocorreu um erro! ");
        }

        private void cmd_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                int dia = int.Parse(txt_dia.Text);
                int mes = int.Parse(txt_mes.Text);
                int ano = int.Parse(txt_ano.Text);

                DateTime data = new DateTime(ano, mes, dia);
                string formata_data = data.ToString("dd-MM-yyyy");

                //num_dia é o numero do dia da semana em ordem, de domingo (0) a sabado (6)
                int num_dia = (int)data.DayOfWeek;

                dias(formata_data, num_dia);
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
