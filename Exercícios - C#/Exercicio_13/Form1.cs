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

        double TotalPagar = 0;
        private void cmd_compra_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(txt_pagamento.Text);
                int parcelas = int.Parse(txt_parcela.Text);
                DateTime data_compra = Convert.ToDateTime(msk_data.Text);

                if ((parcelas > 0) && (valor > 0))
                {
                    int num_dia = (int)data_compra.DayOfWeek;

                    if ((num_dia > 0) && (num_dia < 6))
                    { 
                        TotalPagar += valor;

                        DateTime data_de_vencimento = new DateTime();

                        data_de_vencimento = data_compra.AddMonths(parcelas - 1);

                        string formata_valor = valor.ToString("C2");
                        string formata_valorParcelado = TotalPagar.ToString("C2");

                        txt_resultados.AppendText ("Valor da compra: " + formata_valor
                                + Environment.NewLine + "Número de parcelas: " + parcelas + Environment.NewLine 
                                + "Data de vencimento: "+ data_de_vencimento.ToString("dd-MM-yyyy")
                                + Environment.NewLine + Environment.NewLine);
                        
                        for (int i = 1; i <= parcelas; i++)
                        {
                            data_de_vencimento = data_compra.AddMonths (i - 1);

                            txt_resultados.AppendText 
                            (                           
                                "- " + i + "º" + " Parcela: " + Environment.NewLine + "Dia: "
                                + data_de_vencimento.ToString("dd-MM-yyyy") + Environment.NewLine + Environment.NewLine
                            );
                        }
                        
                        lbl_pagamentoTotal.Visible = true;
                        lbl_pagamentoTotal.Text = Convert.ToString("Pagamento total: " + formata_valorParcelado);
                    }
                    
                    else
                        MessageBox.Show("Não pode ser feita compras em Sábado e Domingo, obrigado pela compreensão",
                                "Dias de serviço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                    MessageBox.Show ("Deve ser digitado valores positivos nas caixas de texto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            catch (Exception erro)
            {
                MessageBox.Show("Houve um erro: \n\n" + erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int numero_da_parcela = 1;
        private void cmd_pagamento_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(txt_pagamento.Text);
                int parcelas = int.Parse(txt_parcela.Text);
                double valor_parcelado = valor / parcelas;

                string formata_valor = valor.ToString("C2");

                DateTime data_compra = Convert.ToDateTime(msk_data.Text);
                DateTime data_pagamento = Convert.ToDateTime(msk_dataPagamento.Text);
                DateTime data_de_vencimento = new DateTime();

                List<DateTime> datas = new List<DateTime>();
                for (int i = 1; i <= parcelas; i++)
                {
                    data_de_vencimento = data_compra.AddMonths(i - 1);
                    datas.Add(data_de_vencimento);
                }

                foreach (DateTime dataParcelas in datas)
                {
                    if (dataParcelas == data_pagamento)
                    {
                        int num_dia = (int)data_compra.DayOfWeek;

                        if ((num_dia > 0) && (num_dia < 6))
                        {
                            for (int contadorLinhas = 0; contadorLinhas < txt_resultados.Lines.Length - 1; contadorLinhas++)
                            {
                                if (txt_resultados.Lines[contadorLinhas].Contains("- " + numero_da_parcela + "º" + " Parcela: "))
                                {
                                    TotalPagar -= valor_parcelado;
                                    lbl_pagamentoTotal.Text = String.Format("Pagamento total: {0:C2}", TotalPagar);

                                    List<string> linhas = new List<string>();

                                    linhas.AddRange(this.txt_resultados.Lines);
                                    linhas.RemoveRange(contadorLinhas, contadorLinhas - 1);

                                    this.txt_resultados.Lines = linhas.ToArray();

                                    break;
                                }
                            }
                            numero_da_parcela++;
                        }
                    }
                    
                    if (data_pagamento > dataParcelas )
                    {
                        MessageBox.Show("Você está pagando atrasado, então por isso terá que receber um juros de 3% em cima do valor da parcela.", "VOCÊ FOI AVISADO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        TotalPagar -= valor_parcelado;

                        lbl_pagamentoTotal.Text = String.Format("Pagamento total: {0:C2}", ((3 * TotalPagar) / 100) + TotalPagar);

                        break;
                    }
                }
            }

            catch (Exception Erro)
            {
                MessageBox.Show("Houve um erro: \n\n" + Erro, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }  

        private void lbl_pagamentoTotal_TextChanged(object sender, EventArgs e)
        {
            string valor = lbl_pagamentoTotal.Text;

            if (valor == "Pagamento total: R$0,00")
            {
                cmd_pagamento.Enabled = false;
                MessageBox.Show("Todos os pagamentos desta compra foram feitos", "Aviso de pagamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
                cmd_pagamento.Enabled = true;
        }

        private void txt_pagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void txt_parcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
