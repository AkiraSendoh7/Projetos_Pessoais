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
        //Processo de criação das variáveis para as funções matemáticas
        double valor;
        bool validacao = false;
        string operador = "";


        public Form1()
        {
            InitializeComponent();
        }

        public void ativar()
        {
            //Ativar os botões  
            if (cmd_adicao.Enabled == false)
            {
                lblSinal.Text = "";
                txt_resultados.Text = "";
                cmd_restoDivisao.Enabled = true;
                cmd_adicao.Enabled = true;
                cmd_subtracao.Enabled = true;
                cmd_multiplicacao.Enabled = true;
                cmd_divisao.Enabled = true;
                cmd_x_a_n.Enabled = true;
                cmd_x_aoCubo.Enabled = true;
                cmdAoQuadrado.Enabled = true;
                cmd_seno.Enabled = true;
                cmd_cosseno.Enabled = true;
                cmd_tangente.Enabled = true;
                cmd_raizY.Enabled = true;
                cmd_raizCubica.Enabled = true;
                cmd_raiz.Enabled = true;
                cmd_porcentagem.Enabled = true;
                cmd_MaisMenos.Enabled = true;
                cmd_exponenciacao.Enabled = true;
                cmd_log.Enabled = true;
                cmd_inverso.Enabled = true;
                cmd_fatorial.Enabled = true;
            }
        }

        public void desativar()
        {
            //Desativar os botões pra quando um resultado é impossível 
            cmd_restoDivisao.Enabled = false;
            cmd_adicao.Enabled = false;
            cmd_subtracao.Enabled = false;
            cmd_multiplicacao.Enabled = false;
            cmd_divisao.Enabled = false;
            cmd_x_a_n.Enabled = false;
            cmd_x_aoCubo.Enabled = false;
            cmdAoQuadrado.Enabled = false;
            cmd_seno.Enabled = false;
            cmd_cosseno.Enabled = false;
            cmd_tangente.Enabled = false;
            cmd_raizY.Enabled = false;
            cmd_raizCubica.Enabled = false;
            cmd_raiz.Enabled = false;
            cmd_porcentagem.Enabled = false;
            cmd_MaisMenos.Enabled = false;
            cmd_exponenciacao.Enabled = false;
            cmd_log.Enabled = false;
            cmd_inverso.Enabled = false;
            cmd_fatorial.Enabled = false;
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {

            //Apaga os dados da caixa de texto
            txt_resultados.Text = "0";
            lblSinal.Text = "";
            valor = 0;
            validacao = false;

            ativar();
        }

        private void cmd_clearLine_Click(object sender, EventArgs e)
        {
            //Apaga a linha atual da caixa de texto  
            txt_resultados.Text = "0";
            valor = 0;
            validacao = false;

            ativar();
        }

        private void cmd_numerador(object sender, EventArgs e)
        {
            //Valor de início
            if ((txt_resultados.Text == "0") || (validacao))
                txt_resultados.Clear();

            validacao = false;
            Button bt0 = (Button)sender;

            //Verificação para número fracionado 
            if (bt0.Text == ",")
            {
                if (!txt_resultados.Text.Contains(","))
                    txt_resultados.Text = txt_resultados.Text + bt0.Text;
            }

            //Se número for inteiro, o valor é retirado sem virgula
            else
                txt_resultados.Text = txt_resultados.Text + bt0.Text;

            ativar();
        }

        private void cmd_operador(object sender, EventArgs e)
        {
            //Pega os dados enviados pelo botão com a tag de 'cmd_operador'
            Button bt0 = (Button)sender;

            //Se o primeiro dígito for diferente de zero, mostra a operação na label e faz o cálculo, suposto
            if (valor != 0)
            {
                cmd_igual.PerformClick();
                operador = bt0.Text;
                lblSinal.Text = valor + "" + operador;
                validacao = true;
            }

            //Se o valor é zero, não há cálculos envolvidos, somente mostra o valor na label  
            else
            {
                operador = bt0.Text;

                //Tratamento de erros e iniciamento da variável valor
                double i;
                if (double.TryParse(txt_resultados.Text, out i))
                    valor = Double.Parse(txt_resultados.Text);

                //Caso o operador seja xⁿ, mudar o valor da label  
                if (operador == "xⁿ")
                    lblSinal.Text = valor + "" + "^";

                //Caso não seja xⁿ, mudar o valor da label
                else
                    lblSinal.Text = valor + "" + operador;

                validacao = true;
            }
        }

        private void cmd_igual_Click(object sender, EventArgs e)
        {
            //Verificação dos operadores para as funções matemáticas
            switch (operador)
            {
                case "+":
                    txt_resultados.Text = Convert.ToString(valor + Convert.ToDouble(txt_resultados.Text));
                    break;
                case "-":
                    txt_resultados.Text = Convert.ToString(valor - Convert.ToDouble(txt_resultados.Text));
                    break;
                case "*":
                    txt_resultados.Text = Convert.ToString(valor * Convert.ToDouble(txt_resultados.Text));
                    break;
                case "/":
                    if ((Convert.ToDouble(txt_resultados.Text) != 0) && (valor != 0))
                        txt_resultados.Text = Convert.ToString(valor / Convert.ToDouble(txt_resultados.Text));
                    else
                    {
                        txt_resultados.Text = Convert.ToString("Não é possível possível dividir por zero");
                        desativar();
                    }

                    break;
                case "xⁿ":
                    double Expoente = Convert.ToDouble(txt_resultados.Text);
                    double Base = (valor);
                    txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(Base, Expoente)));
                    break;
                case "Mod":
                    txt_resultados.Text = Convert.ToString(valor % Convert.ToDouble(txt_resultados.Text));
                    break;
                case "yroot":
                    double indice = Convert.ToDouble(txt_resultados.Text);
                    double radicando = (valor);
                    txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(radicando, 1 / indice)));
                    break;
                default:
                    break;

            }

            double i;
            if (double.TryParse(txt_resultados.Text, out i))
            {
                valor = Double.Parse(txt_resultados.Text);
                lblSinal.Text = "";
            }
        }

        private void cmd_seta_Click(object sender, EventArgs e)
        {
            //Remover um dígito
            if (txt_resultados.Text.Length > 0)
                txt_resultados.Text = txt_resultados.Text.Remove(txt_resultados.Text.Length - 1, 1);

            //Caso já tenha apagado todos os dígitos, aparecer 0 
            if (txt_resultados.Text == "")
                txt_resultados.Text = "0";
        }

        private void cmd_inversor(object sender, EventArgs e)
        {
            //Cálculo do inverso, caso o número não seja 0 
            if (Convert.ToDouble(txt_resultados.Text) != 0)
                txt_resultados.Text = Convert.ToString(1 / Convert.ToDouble(txt_resultados.Text));

            //Divisão por zero é indefinido
            else
            {
                txt_resultados.Text = "Não é possível dividir por zero :( ";
                desativar();
            }

        }

        private void cmd_log_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt_resultados.Text) > 0)
            {
                double log10 = Convert.ToDouble(txt_resultados.Text);
                lblSinal.Text = Convert.ToString("log" + "(" + (txt_resultados.Text) + ")");
                log10 = Math.Log10(log10);
                txt_resultados.Text = Convert.ToString(log10);

            }
            else
            {
                txt_resultados.Text = ("Entrada inválida");
                lblSinal.Text = "log(0)";

                desativar();
            }

        }

        private void cmd_raiz_Click(object sender, EventArgs e)
        {

            if (Convert.ToDouble(txt_resultados.Text) > 0)
            {
                double sqrt = Convert.ToDouble(txt_resultados.Text);
                lblSinal.Text = Convert.ToString("√" + "(" + sqrt + ")");
                sqrt = Math.Sqrt(sqrt);
                txt_resultados.Text = Convert.ToString(sqrt);

            }
            else if (Convert.ToDouble(txt_resultados.Text) == 0)
            {
                txt_resultados.Text = "0";
                lblSinal.Text = Convert.ToString("√(0)");
            }
            else
            {
                double sqrtN = Convert.ToDouble(txt_resultados.Text);
                lblSinal.Text = Convert.ToString("√" + "(" + sqrtN + ")");
                txt_resultados.Text = "Entrada inválida";

                desativar();
            }
        }

        private void cmd_raizCubica_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txt_resultados.Text);
            lblSinal.Text = Convert.ToString("∛" + "(" + sqrt + ")");
            sqrt = (Math.Pow(sqrt, (double)1 / 3));
            txt_resultados.Text = Convert.ToString(sqrt);

        }

        private void cmdAoQuadrado_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_resultados.Text);

            lblSinal.Text = Convert.ToString("sqr" + "(" + txt_resultados.Text + ")");
            txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(a, 2)));

        }

        private void cmd_x_aoCubo_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(txt_resultados.Text);

            lblSinal.Text = Convert.ToString("cube" + "(" + txt_resultados.Text + ")");
            txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(b, 3)));
        }

        private void cmd_seno_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double sin = Convert.ToDouble(txt_resultados.Text) * pi / Convert.ToDouble(180);
            lblSinal.Text = Convert.ToString("sin" + "(" + (txt_resultados.Text) + ")");
            sin = Math.Sin(sin);
            txt_resultados.Text = Convert.ToString(sin);

        }

        private void cmd_cosseno_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double cos = Convert.ToDouble(txt_resultados.Text) * pi / Convert.ToDouble(180);
            lblSinal.Text = Convert.ToString("cos" + "(" + (txt_resultados.Text) + ")");
            cos = Math.Cos(cos);
            txt_resultados.Text = Convert.ToString(cos);

        }

        private void cmd_tangente_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            double tg = Convert.ToDouble(txt_resultados.Text) * pi / Convert.ToDouble(180);
            lblSinal.Text = Convert.ToString("tg" + "(" + (txt_resultados.Text) + ")");
            tg = Math.Tan(tg);
            txt_resultados.Text = Convert.ToString(tg);

        }

        private void cmd_fatorial_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txt_resultados.Text);
            int f = 1;

            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                    f = f * i;

                txt_resultados.Text = Convert.ToString(f);
                lblSinal.Text = Convert.ToString(n + "!");
            }
            else
            {
                txt_resultados.Text = Convert.ToString("Não existe fatorial de número negativo :(");
                desativar();
            }
        }

        private void cmd_exponenciacao_Click(object sender, EventArgs e)
        {
            double Expoente = Convert.ToDouble(txt_resultados.Text);
            txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(10, Expoente)));
            lblSinal.Text = Convert.ToString(10 + "^" + Expoente);
        }

        private void cmd_MaisMenos_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(txt_resultados.Text);
            int sinal = Math.Sign(a);
            if (sinal == 1 || sinal == -1)
            {
                a = a * (-1);
                txt_resultados.Text = Convert.ToString(a);
            }
            txt_resultados.Text = (a).ToString();
            lblSinal.Text = "";
        }

        private void cmd_x_a_n_Click(object sender, EventArgs e)
        {

            double Expoente = Convert.ToDouble(txt_resultados.Text);
            double Base = (valor);
            txt_resultados.Text = Convert.ToString(Convert.ToDouble(Math.Pow(Base, Expoente)));

            lblSinal.Text = Convert.ToString(Base + "^" + Expoente);
            validacao = true;

        }

        private void cmd_porcentagem_Click(object sender, EventArgs e)
        {
            double val = Double.Parse(txt_resultados.Text);
            val = val / 100;
            double result = valor * val;
            txt_resultados.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Correção de erro, não sei qual seja, no entanto 
        }
    }
}
