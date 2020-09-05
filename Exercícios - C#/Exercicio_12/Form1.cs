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

        private static string cadastro(string nome, string matricula)
        {
            int id = int.Parse(matricula);
            string dias = "";

            if ((id < 3) || (id > 5))
            {
                string resposta = "O número de matrícula do aluno " + nome + " ,é inexistente";
                return resposta;
            }

            else
            {
                switch (id)
                {
                    case 3:
                        dias = "Segunda e Quarta";
                        break;

                    case 4:
                        dias = "Terça e Quinta";
                        break;

                    case 5:
                        dias = "Quarta e Sexta";
                        break;
                }

                string resposta = ("O aluno " + nome + "tem suas aulas nos dias: " + dias);
                return resposta;
            }
        }

        private void cmd_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(txt_nome.Text);
                string id = Convert.ToString(txt_matricula.Text);

                //Inicializa com o 1º dígito da matrícula digitada
                string id_formatado = Convert.ToString(id[0]);

                string resultado = cadastro(name, id_formatado);

                txt_resultados.AppendText(resultado + Environment.NewLine);

                //Limpar a caixa de texto após a inserção de dados
                txt_nome.Text = null;
                txt_matricula.Text = null;

            }

            catch (Exception)
            {
                MessageBox.Show("Um erro ocorreu! Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            int saida;
            bool IsNumber = false;

            IsNumber = int.TryParse(txt_nome.Text, out saida);
            if (IsNumber)
                txt_nome.Text = null;
        }

        private void txt_matricula_TextChanged(object sender, EventArgs e)
        {
            int saida;
            bool IsNumber = false;

            IsNumber = int.TryParse(txt_matricula.Text, out saida);
            if (!IsNumber)
                txt_matricula.Text = null;
        }
    }
}
