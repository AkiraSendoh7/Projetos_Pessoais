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

        private void cmd_calculo_Click(object sender, EventArgs e)
        {

            try
            {
                float capital_inicial = 0.00f;
                float time = 0.00f;
                float juros = 0.00f;
                double interest_rate = 0.00f;

                //Valor do capital inicial investido (R$)
                capital_inicial = float.Parse(txt_capital.Text);
                string formata_capital = string.Format("Valor = {0:C2}", capital_inicial);

                //Tempo de investimento (meses)
                time = float.Parse(txt_tempo.Text);
                string formata_time = time.ToString("0.00");

                //Valor do Juros sobre o capital inicial (R$)
                juros = float.Parse(txt_juros.Text);
                string formata_juros = juros.ToString("0.00");

                //Valor da taxa sobre o capital inicial investido em um tempo t
                interest_rate = (juros) / (capital_inicial * time);
                double i = interest_rate * 100;
                string formata_taxa = string.Format("{0:F3}", i);

                MessageBox.Show(string.Format("A taxa sobre o capital inicial por mês é equivalente a: " + formata_taxa + "%"), "Valor da taxa");

            }
            catch (Exception)
            {
                string message = "Um erro ocorreu! \n ";
                string title = "Mensagem de Erro";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
