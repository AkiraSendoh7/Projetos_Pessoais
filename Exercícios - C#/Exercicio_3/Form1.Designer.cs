//Feito por AkiraSendoh7 
//https://github.com/AkiraSendoh7/Projetos_Pessoais.git
//Usar com moderação, sempre bom

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.cmd_raiz = new System.Windows.Forms.Button();
            this.cmd_MaisMenos = new System.Windows.Forms.Button();
            this.cmd_clear = new System.Windows.Forms.Button();
            this.cmd_clearLine = new System.Windows.Forms.Button();
            this.cmd_seta = new System.Windows.Forms.Button();
            this.cmd_porcentagem = new System.Windows.Forms.Button();
            this.cmd_inverso = new System.Windows.Forms.Button();
            this.cmd_igual = new System.Windows.Forms.Button();
            this.cmd_divisao = new System.Windows.Forms.Button();
            this.cmd_multiplicacao = new System.Windows.Forms.Button();
            this.cmd_subtracao = new System.Windows.Forms.Button();
            this.cmd_nove = new System.Windows.Forms.Button();
            this.cmd_oito = new System.Windows.Forms.Button();
            this.cmd_sete = new System.Windows.Forms.Button();
            this.cmd_seis = new System.Windows.Forms.Button();
            this.cmd_cinco = new System.Windows.Forms.Button();
            this.cmd_quatro = new System.Windows.Forms.Button();
            this.cmd_tres = new System.Windows.Forms.Button();
            this.cmd_dois = new System.Windows.Forms.Button();
            this.cmd_um = new System.Windows.Forms.Button();
            this.cmd_zero = new System.Windows.Forms.Button();
            this.cmd_virgula = new System.Windows.Forms.Button();
            this.cmdAoQuadrado = new System.Windows.Forms.Button();
            this.cmd_seno = new System.Windows.Forms.Button();
            this.cmd_fatorial = new System.Windows.Forms.Button();
            this.cmd_raizY = new System.Windows.Forms.Button();
            this.cmd_cosseno = new System.Windows.Forms.Button();
            this.cmd_x_a_n = new System.Windows.Forms.Button();
            this.cmd_raizCubica = new System.Windows.Forms.Button();
            this.cmd_x_aoCubo = new System.Windows.Forms.Button();
            this.cmd_tangente = new System.Windows.Forms.Button();
            this.cmd_exponenciacao = new System.Windows.Forms.Button();
            this.cmd_log = new System.Windows.Forms.Button();
            this.cmd_restoDivisao = new System.Windows.Forms.Button();
            this.cmd_adicao = new System.Windows.Forms.Button();
            this.lbl_sinal = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_resultados
            // 
            this.txt_resultados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultados.Location = new System.Drawing.Point(304, 44);
            this.txt_resultados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.ReadOnly = true;
            this.txt_resultados.Size = new System.Drawing.Size(502, 30);
            this.txt_resultados.TabIndex = 0;
            this.txt_resultados.Text = "0";
            this.txt_resultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmd_raiz
            // 
            this.cmd_raiz.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_raiz.Location = new System.Drawing.Point(724, 120);
            this.cmd_raiz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_raiz.Name = "cmd_raiz";
            this.cmd_raiz.Size = new System.Drawing.Size(82, 46);
            this.cmd_raiz.TabIndex = 1;
            this.cmd_raiz.Text = "√";
            this.cmd_raiz.UseVisualStyleBackColor = true;
            this.cmd_raiz.Click += new System.EventHandler(this.cmd_raiz_Click);
            // 
            // cmd_MaisMenos
            // 
            this.cmd_MaisMenos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_MaisMenos.Location = new System.Drawing.Point(600, 120);
            this.cmd_MaisMenos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_MaisMenos.Name = "cmd_MaisMenos";
            this.cmd_MaisMenos.Size = new System.Drawing.Size(82, 46);
            this.cmd_MaisMenos.TabIndex = 2;
            this.cmd_MaisMenos.Text = "±";
            this.cmd_MaisMenos.UseVisualStyleBackColor = true;
            this.cmd_MaisMenos.Click += new System.EventHandler(this.cmd_MaisMenos_Click);
            // 
            // cmd_clear
            // 
            this.cmd_clear.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_clear.Location = new System.Drawing.Point(502, 120);
            this.cmd_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_clear.Name = "cmd_clear";
            this.cmd_clear.Size = new System.Drawing.Size(82, 46);
            this.cmd_clear.TabIndex = 3;
            this.cmd_clear.Text = "C";
            this.cmd_clear.UseVisualStyleBackColor = true;
            this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
            // 
            // cmd_clearLine
            // 
            this.cmd_clearLine.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_clearLine.Location = new System.Drawing.Point(399, 120);
            this.cmd_clearLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_clearLine.Name = "cmd_clearLine";
            this.cmd_clearLine.Size = new System.Drawing.Size(82, 46);
            this.cmd_clearLine.TabIndex = 4;
            this.cmd_clearLine.Text = "CE";
            this.cmd_clearLine.UseVisualStyleBackColor = true;
            this.cmd_clearLine.Click += new System.EventHandler(this.cmd_clearLine_Click);
            // 
            // cmd_seta
            // 
            this.cmd_seta.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_seta.Location = new System.Drawing.Point(304, 120);
            this.cmd_seta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_seta.Name = "cmd_seta";
            this.cmd_seta.Size = new System.Drawing.Size(82, 46);
            this.cmd_seta.TabIndex = 5;
            this.cmd_seta.Text = "←";
            this.cmd_seta.UseVisualStyleBackColor = true;
            this.cmd_seta.Click += new System.EventHandler(this.cmd_seta_Click);
            // 
            // cmd_porcentagem
            // 
            this.cmd_porcentagem.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_porcentagem.Location = new System.Drawing.Point(724, 196);
            this.cmd_porcentagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_porcentagem.Name = "cmd_porcentagem";
            this.cmd_porcentagem.Size = new System.Drawing.Size(82, 46);
            this.cmd_porcentagem.TabIndex = 6;
            this.cmd_porcentagem.Text = "%";
            this.cmd_porcentagem.UseVisualStyleBackColor = true;
            this.cmd_porcentagem.Click += new System.EventHandler(this.cmd_porcentagem_Click);
            // 
            // cmd_inverso
            // 
            this.cmd_inverso.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_inverso.Location = new System.Drawing.Point(724, 267);
            this.cmd_inverso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_inverso.Name = "cmd_inverso";
            this.cmd_inverso.Size = new System.Drawing.Size(82, 48);
            this.cmd_inverso.TabIndex = 7;
            this.cmd_inverso.Text = "1/x";
            this.cmd_inverso.UseVisualStyleBackColor = true;
            this.cmd_inverso.Click += new System.EventHandler(this.cmd_inversor);
            // 
            // cmd_igual
            // 
            this.cmd_igual.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_igual.Location = new System.Drawing.Point(724, 335);
            this.cmd_igual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_igual.Name = "cmd_igual";
            this.cmd_igual.Size = new System.Drawing.Size(82, 121);
            this.cmd_igual.TabIndex = 8;
            this.cmd_igual.Text = "=";
            this.cmd_igual.UseVisualStyleBackColor = true;
            this.cmd_igual.Click += new System.EventHandler(this.cmd_igual_Click);
            // 
            // cmd_divisao
            // 
            this.cmd_divisao.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_divisao.Location = new System.Drawing.Point(600, 196);
            this.cmd_divisao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_divisao.Name = "cmd_divisao";
            this.cmd_divisao.Size = new System.Drawing.Size(82, 46);
            this.cmd_divisao.TabIndex = 9;
            this.cmd_divisao.Text = "/";
            this.cmd_divisao.UseVisualStyleBackColor = true;
            this.cmd_divisao.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_multiplicacao
            // 
            this.cmd_multiplicacao.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_multiplicacao.Location = new System.Drawing.Point(600, 267);
            this.cmd_multiplicacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_multiplicacao.Name = "cmd_multiplicacao";
            this.cmd_multiplicacao.Size = new System.Drawing.Size(82, 46);
            this.cmd_multiplicacao.TabIndex = 10;
            this.cmd_multiplicacao.Text = "*";
            this.cmd_multiplicacao.UseVisualStyleBackColor = true;
            this.cmd_multiplicacao.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_subtracao
            // 
            this.cmd_subtracao.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_subtracao.Location = new System.Drawing.Point(600, 333);
            this.cmd_subtracao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_subtracao.Name = "cmd_subtracao";
            this.cmd_subtracao.Size = new System.Drawing.Size(82, 46);
            this.cmd_subtracao.TabIndex = 11;
            this.cmd_subtracao.Text = "-";
            this.cmd_subtracao.UseVisualStyleBackColor = true;
            this.cmd_subtracao.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_nove
            // 
            this.cmd_nove.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_nove.Location = new System.Drawing.Point(502, 196);
            this.cmd_nove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_nove.Name = "cmd_nove";
            this.cmd_nove.Size = new System.Drawing.Size(82, 46);
            this.cmd_nove.TabIndex = 13;
            this.cmd_nove.Text = "9";
            this.cmd_nove.UseVisualStyleBackColor = true;
            this.cmd_nove.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_oito
            // 
            this.cmd_oito.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_oito.Location = new System.Drawing.Point(399, 196);
            this.cmd_oito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_oito.Name = "cmd_oito";
            this.cmd_oito.Size = new System.Drawing.Size(82, 46);
            this.cmd_oito.TabIndex = 14;
            this.cmd_oito.Text = "8";
            this.cmd_oito.UseVisualStyleBackColor = true;
            this.cmd_oito.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_sete
            // 
            this.cmd_sete.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sete.Location = new System.Drawing.Point(304, 196);
            this.cmd_sete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_sete.Name = "cmd_sete";
            this.cmd_sete.Size = new System.Drawing.Size(82, 46);
            this.cmd_sete.TabIndex = 15;
            this.cmd_sete.Text = "7";
            this.cmd_sete.UseVisualStyleBackColor = true;
            this.cmd_sete.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_seis
            // 
            this.cmd_seis.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_seis.Location = new System.Drawing.Point(502, 267);
            this.cmd_seis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_seis.Name = "cmd_seis";
            this.cmd_seis.Size = new System.Drawing.Size(82, 46);
            this.cmd_seis.TabIndex = 16;
            this.cmd_seis.Text = "6";
            this.cmd_seis.UseVisualStyleBackColor = true;
            this.cmd_seis.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_cinco
            // 
            this.cmd_cinco.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cinco.Location = new System.Drawing.Point(399, 267);
            this.cmd_cinco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_cinco.Name = "cmd_cinco";
            this.cmd_cinco.Size = new System.Drawing.Size(82, 46);
            this.cmd_cinco.TabIndex = 17;
            this.cmd_cinco.Text = "5";
            this.cmd_cinco.UseVisualStyleBackColor = true;
            this.cmd_cinco.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_quatro
            // 
            this.cmd_quatro.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_quatro.Location = new System.Drawing.Point(304, 267);
            this.cmd_quatro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_quatro.Name = "cmd_quatro";
            this.cmd_quatro.Size = new System.Drawing.Size(82, 46);
            this.cmd_quatro.TabIndex = 18;
            this.cmd_quatro.Text = "4";
            this.cmd_quatro.UseVisualStyleBackColor = true;
            this.cmd_quatro.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_tres
            // 
            this.cmd_tres.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_tres.Location = new System.Drawing.Point(502, 333);
            this.cmd_tres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_tres.Name = "cmd_tres";
            this.cmd_tres.Size = new System.Drawing.Size(82, 46);
            this.cmd_tres.TabIndex = 19;
            this.cmd_tres.Text = "3";
            this.cmd_tres.UseVisualStyleBackColor = true;
            this.cmd_tres.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_dois
            // 
            this.cmd_dois.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_dois.Location = new System.Drawing.Point(399, 333);
            this.cmd_dois.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_dois.Name = "cmd_dois";
            this.cmd_dois.Size = new System.Drawing.Size(82, 46);
            this.cmd_dois.TabIndex = 20;
            this.cmd_dois.Text = "2";
            this.cmd_dois.UseVisualStyleBackColor = true;
            this.cmd_dois.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_um
            // 
            this.cmd_um.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_um.Location = new System.Drawing.Point(304, 333);
            this.cmd_um.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_um.Name = "cmd_um";
            this.cmd_um.Size = new System.Drawing.Size(82, 46);
            this.cmd_um.TabIndex = 21;
            this.cmd_um.Text = "1";
            this.cmd_um.UseVisualStyleBackColor = true;
            this.cmd_um.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_zero
            // 
            this.cmd_zero.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_zero.Location = new System.Drawing.Point(304, 412);
            this.cmd_zero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_zero.Name = "cmd_zero";
            this.cmd_zero.Size = new System.Drawing.Size(177, 46);
            this.cmd_zero.TabIndex = 22;
            this.cmd_zero.Text = "0";
            this.cmd_zero.UseVisualStyleBackColor = true;
            this.cmd_zero.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmd_virgula
            // 
            this.cmd_virgula.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_virgula.Location = new System.Drawing.Point(502, 412);
            this.cmd_virgula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_virgula.Name = "cmd_virgula";
            this.cmd_virgula.Size = new System.Drawing.Size(82, 46);
            this.cmd_virgula.TabIndex = 23;
            this.cmd_virgula.Text = ",";
            this.cmd_virgula.UseVisualStyleBackColor = true;
            this.cmd_virgula.Click += new System.EventHandler(this.cmd_numerador);
            // 
            // cmdAoQuadrado
            // 
            this.cmdAoQuadrado.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAoQuadrado.Location = new System.Drawing.Point(103, 196);
            this.cmdAoQuadrado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAoQuadrado.Name = "cmdAoQuadrado";
            this.cmdAoQuadrado.Size = new System.Drawing.Size(82, 46);
            this.cmdAoQuadrado.TabIndex = 24;
            this.cmdAoQuadrado.Text = "x²";
            this.cmdAoQuadrado.UseVisualStyleBackColor = true;
            this.cmdAoQuadrado.Click += new System.EventHandler(this.cmdAoQuadrado_Click);
            // 
            // cmd_seno
            // 
            this.cmd_seno.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_seno.Location = new System.Drawing.Point(12, 196);
            this.cmd_seno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_seno.Name = "cmd_seno";
            this.cmd_seno.Size = new System.Drawing.Size(82, 46);
            this.cmd_seno.TabIndex = 25;
            this.cmd_seno.Text = "sin";
            this.cmd_seno.UseVisualStyleBackColor = true;
            this.cmd_seno.Click += new System.EventHandler(this.cmd_seno_Click);
            // 
            // cmd_fatorial
            // 
            this.cmd_fatorial.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fatorial.Location = new System.Drawing.Point(194, 196);
            this.cmd_fatorial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_fatorial.Name = "cmd_fatorial";
            this.cmd_fatorial.Size = new System.Drawing.Size(82, 46);
            this.cmd_fatorial.TabIndex = 26;
            this.cmd_fatorial.Text = "n!";
            this.cmd_fatorial.UseVisualStyleBackColor = true;
            this.cmd_fatorial.Click += new System.EventHandler(this.cmd_fatorial_Click);
            // 
            // cmd_raizY
            // 
            this.cmd_raizY.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_raizY.Location = new System.Drawing.Point(194, 267);
            this.cmd_raizY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_raizY.Name = "cmd_raizY";
            this.cmd_raizY.Size = new System.Drawing.Size(82, 48);
            this.cmd_raizY.TabIndex = 27;
            this.cmd_raizY.Text = "yroot";
            this.cmd_raizY.UseVisualStyleBackColor = true;
            this.cmd_raizY.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_cosseno
            // 
            this.cmd_cosseno.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cosseno.Location = new System.Drawing.Point(12, 267);
            this.cmd_cosseno.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_cosseno.Name = "cmd_cosseno";
            this.cmd_cosseno.Size = new System.Drawing.Size(82, 46);
            this.cmd_cosseno.TabIndex = 28;
            this.cmd_cosseno.Text = "cos";
            this.cmd_cosseno.UseVisualStyleBackColor = true;
            this.cmd_cosseno.Click += new System.EventHandler(this.cmd_cosseno_Click);
            // 
            // cmd_x_a_n
            // 
            this.cmd_x_a_n.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_x_a_n.Location = new System.Drawing.Point(103, 267);
            this.cmd_x_a_n.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_x_a_n.Name = "cmd_x_a_n";
            this.cmd_x_a_n.Size = new System.Drawing.Size(82, 46);
            this.cmd_x_a_n.TabIndex = 29;
            this.cmd_x_a_n.Text = "xⁿ";
            this.cmd_x_a_n.UseVisualStyleBackColor = true;
            this.cmd_x_a_n.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_raizCubica
            // 
            this.cmd_raizCubica.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_raizCubica.Location = new System.Drawing.Point(194, 333);
            this.cmd_raizCubica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_raizCubica.Name = "cmd_raizCubica";
            this.cmd_raizCubica.Size = new System.Drawing.Size(82, 46);
            this.cmd_raizCubica.TabIndex = 30;
            this.cmd_raizCubica.Text = "∛x";
            this.cmd_raizCubica.UseVisualStyleBackColor = true;
            this.cmd_raizCubica.Click += new System.EventHandler(this.cmd_raizCubica_Click);
            // 
            // cmd_x_aoCubo
            // 
            this.cmd_x_aoCubo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_x_aoCubo.Location = new System.Drawing.Point(103, 333);
            this.cmd_x_aoCubo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_x_aoCubo.Name = "cmd_x_aoCubo";
            this.cmd_x_aoCubo.Size = new System.Drawing.Size(82, 46);
            this.cmd_x_aoCubo.TabIndex = 31;
            this.cmd_x_aoCubo.Text = "х³\t";
            this.cmd_x_aoCubo.UseVisualStyleBackColor = true;
            this.cmd_x_aoCubo.Click += new System.EventHandler(this.cmd_x_aoCubo_Click);
            // 
            // cmd_tangente
            // 
            this.cmd_tangente.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_tangente.Location = new System.Drawing.Point(12, 333);
            this.cmd_tangente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_tangente.Name = "cmd_tangente";
            this.cmd_tangente.Size = new System.Drawing.Size(82, 46);
            this.cmd_tangente.TabIndex = 32;
            this.cmd_tangente.Text = "tg";
            this.cmd_tangente.UseVisualStyleBackColor = true;
            this.cmd_tangente.Click += new System.EventHandler(this.cmd_tangente_Click);
            // 
            // cmd_exponenciacao
            // 
            this.cmd_exponenciacao.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_exponenciacao.Location = new System.Drawing.Point(194, 412);
            this.cmd_exponenciacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_exponenciacao.Name = "cmd_exponenciacao";
            this.cmd_exponenciacao.Size = new System.Drawing.Size(82, 46);
            this.cmd_exponenciacao.TabIndex = 33;
            this.cmd_exponenciacao.Text = "10ⁿ";
            this.cmd_exponenciacao.UseVisualStyleBackColor = true;
            this.cmd_exponenciacao.Click += new System.EventHandler(this.cmd_exponenciacao_Click);
            // 
            // cmd_log
            // 
            this.cmd_log.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_log.Location = new System.Drawing.Point(103, 412);
            this.cmd_log.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_log.Name = "cmd_log";
            this.cmd_log.Size = new System.Drawing.Size(82, 46);
            this.cmd_log.TabIndex = 34;
            this.cmd_log.Text = "log";
            this.cmd_log.UseVisualStyleBackColor = true;
            this.cmd_log.Click += new System.EventHandler(this.cmd_log_Click);
            // 
            // cmd_restoDivisao
            // 
            this.cmd_restoDivisao.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_restoDivisao.Location = new System.Drawing.Point(12, 412);
            this.cmd_restoDivisao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_restoDivisao.Name = "cmd_restoDivisao";
            this.cmd_restoDivisao.Size = new System.Drawing.Size(82, 46);
            this.cmd_restoDivisao.TabIndex = 35;
            this.cmd_restoDivisao.Text = "Mod";
            this.cmd_restoDivisao.UseVisualStyleBackColor = true;
            this.cmd_restoDivisao.Click += new System.EventHandler(this.cmd_operador);
            // 
            // cmd_adicao
            // 
            this.cmd_adicao.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_adicao.Location = new System.Drawing.Point(600, 408);
            this.cmd_adicao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_adicao.Name = "cmd_adicao";
            this.cmd_adicao.Size = new System.Drawing.Size(82, 46);
            this.cmd_adicao.TabIndex = 12;
            this.cmd_adicao.Text = "+";
            this.cmd_adicao.UseVisualStyleBackColor = true;
            this.cmd_adicao.Click += new System.EventHandler(this.cmd_operador);
            // 
            // lbl_sinal
            // 
            this.lbl_sinal.AutoSize = true;
            this.lbl_sinal.Location = new System.Drawing.Point(191, 35);
            this.lbl_sinal.Name = "lbl_sinal";
            this.lbl_sinal.Size = new System.Drawing.Size(0, 15);
            this.lbl_sinal.TabIndex = 36;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.SystemColors.Window;
            this.lblSinal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(8, 44);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(18, 20);
            this.lblSinal.TabIndex = 37;
            this.lblSinal.Text = "0";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(850, 479);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lbl_sinal);
            this.Controls.Add(this.cmd_restoDivisao);
            this.Controls.Add(this.cmd_log);
            this.Controls.Add(this.cmd_exponenciacao);
            this.Controls.Add(this.cmd_tangente);
            this.Controls.Add(this.cmd_x_aoCubo);
            this.Controls.Add(this.cmd_raizCubica);
            this.Controls.Add(this.cmd_x_a_n);
            this.Controls.Add(this.cmd_cosseno);
            this.Controls.Add(this.cmd_raizY);
            this.Controls.Add(this.cmd_fatorial);
            this.Controls.Add(this.cmd_seno);
            this.Controls.Add(this.cmdAoQuadrado);
            this.Controls.Add(this.cmd_virgula);
            this.Controls.Add(this.cmd_zero);
            this.Controls.Add(this.cmd_um);
            this.Controls.Add(this.cmd_dois);
            this.Controls.Add(this.cmd_tres);
            this.Controls.Add(this.cmd_quatro);
            this.Controls.Add(this.cmd_cinco);
            this.Controls.Add(this.cmd_seis);
            this.Controls.Add(this.cmd_sete);
            this.Controls.Add(this.cmd_oito);
            this.Controls.Add(this.cmd_nove);
            this.Controls.Add(this.cmd_adicao);
            this.Controls.Add(this.cmd_subtracao);
            this.Controls.Add(this.cmd_multiplicacao);
            this.Controls.Add(this.cmd_divisao);
            this.Controls.Add(this.cmd_igual);
            this.Controls.Add(this.cmd_inverso);
            this.Controls.Add(this.cmd_porcentagem);
            this.Controls.Add(this.cmd_seta);
            this.Controls.Add(this.cmd_clearLine);
            this.Controls.Add(this.cmd_clear);
            this.Controls.Add(this.cmd_MaisMenos);
            this.Controls.Add(this.cmd_raiz);
            this.Controls.Add(this.txt_resultados);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Button cmd_raiz;
        private System.Windows.Forms.Button cmd_MaisMenos;
        private System.Windows.Forms.Button cmd_clear;
        private System.Windows.Forms.Button cmd_clearLine;
        private System.Windows.Forms.Button cmd_seta;
        private System.Windows.Forms.Button cmd_porcentagem;
        private System.Windows.Forms.Button cmd_inverso;
        private System.Windows.Forms.Button cmd_igual;
        private System.Windows.Forms.Button cmd_divisao;
        private System.Windows.Forms.Button cmd_multiplicacao;
        private System.Windows.Forms.Button cmd_subtracao;
        private System.Windows.Forms.Button cmd_nove;
        private System.Windows.Forms.Button cmd_oito;
        private System.Windows.Forms.Button cmd_sete;
        private System.Windows.Forms.Button cmd_seis;
        private System.Windows.Forms.Button cmd_cinco;
        private System.Windows.Forms.Button cmd_quatro;
        private System.Windows.Forms.Button cmd_tres;
        private System.Windows.Forms.Button cmd_dois;
        private System.Windows.Forms.Button cmd_um;
        private System.Windows.Forms.Button cmd_zero;
        private System.Windows.Forms.Button cmd_virgula;
        private System.Windows.Forms.Button cmdAoQuadrado;
        private System.Windows.Forms.Button cmd_seno;
        private System.Windows.Forms.Button cmd_fatorial;
        private System.Windows.Forms.Button cmd_raizY;
        private System.Windows.Forms.Button cmd_cosseno;
        private System.Windows.Forms.Button cmd_x_a_n;
        private System.Windows.Forms.Button cmd_raizCubica;
        private System.Windows.Forms.Button cmd_x_aoCubo;
        private System.Windows.Forms.Button cmd_tangente;
        private System.Windows.Forms.Button cmd_exponenciacao;
        private System.Windows.Forms.Button cmd_log;
        private System.Windows.Forms.Button cmd_restoDivisao;
        private System.Windows.Forms.Button cmd_adicao;
        private System.Windows.Forms.Label lbl_sinal;
        private System.Windows.Forms.Label lblSinal;

    }
}

