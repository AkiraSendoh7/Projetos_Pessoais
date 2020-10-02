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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_comprar = new System.Windows.Forms.Label();
            this.txt_pagamento = new System.Windows.Forms.TextBox();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.lbl_pagamentoTotal = new System.Windows.Forms.Label();
            this.cmd_compra = new System.Windows.Forms.Button();
            this.lbl_valorJuros = new System.Windows.Forms.Label();
            this.lbl_parcela = new System.Windows.Forms.Label();
            this.txt_parcela = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.msk_data = new System.Windows.Forms.MaskedTextBox();
            this.lbl_realizarPagamento = new System.Windows.Forms.Label();
            this.cmd_pagamento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dataPagamento = new System.Windows.Forms.Label();
            this.msk_dataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_comprar
            // 
            this.lbl_comprar.AutoSize = true;
            this.lbl_comprar.Location = new System.Drawing.Point(25, 27);
            this.lbl_comprar.Name = "lbl_comprar";
            this.lbl_comprar.Size = new System.Drawing.Size(138, 15);
            this.lbl_comprar.TabIndex = 2;
            this.lbl_comprar.Text = "Digite o valor da compra: ";
            // 
            // txt_pagamento
            // 
            this.txt_pagamento.Location = new System.Drawing.Point(28, 64);
            this.txt_pagamento.Name = "txt_pagamento";
            this.txt_pagamento.Size = new System.Drawing.Size(144, 23);
            this.txt_pagamento.TabIndex = 3;
            this.txt_pagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pagamento_KeyPress);
            // 
            // txt_resultados
            // 
            this.txt_resultados.Location = new System.Drawing.Point(221, 64);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.ReadOnly = true;
            this.txt_resultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_resultados.Size = new System.Drawing.Size(241, 211);
            this.txt_resultados.TabIndex = 4;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Location = new System.Drawing.Point(218, 27);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(228, 15);
            this.lbl_resultados.TabIndex = 5;
            this.lbl_resultados.Text = "Resultado das parcelas e seus vencimentos: \r\n";
            // 
            // lbl_pagamentoTotal
            // 
            this.lbl_pagamentoTotal.AutoSize = true;
            this.lbl_pagamentoTotal.Location = new System.Drawing.Point(25, 310);
            this.lbl_pagamentoTotal.Name = "lbl_pagamentoTotal";
            this.lbl_pagamentoTotal.Size = new System.Drawing.Size(0, 15);
            this.lbl_pagamentoTotal.TabIndex = 6;
            this.lbl_pagamentoTotal.Visible = false;
            this.lbl_pagamentoTotal.TextChanged += new System.EventHandler(this.lbl_pagamentoTotal_TextChanged);
            // 
            // cmd_compra
            // 
            this.cmd_compra.Location = new System.Drawing.Point(221, 301);
            this.cmd_compra.Name = "cmd_compra";
            this.cmd_compra.Size = new System.Drawing.Size(241, 32);
            this.cmd_compra.TabIndex = 7;
            this.cmd_compra.Text = "Realizar a compra";
            this.cmd_compra.UseVisualStyleBackColor = true;
            this.cmd_compra.Click += new System.EventHandler(this.cmd_compra_Click);
            // 
            // lbl_valorJuros
            // 
            this.lbl_valorJuros.AutoSize = true;
            this.lbl_valorJuros.Location = new System.Drawing.Point(218, 194);
            this.lbl_valorJuros.Name = "lbl_valorJuros";
            this.lbl_valorJuros.Size = new System.Drawing.Size(0, 15);
            this.lbl_valorJuros.TabIndex = 8;
            // 
            // lbl_parcela
            // 
            this.lbl_parcela.AutoSize = true;
            this.lbl_parcela.Location = new System.Drawing.Point(25, 215);
            this.lbl_parcela.Name = "lbl_parcela";
            this.lbl_parcela.Size = new System.Drawing.Size(155, 15);
            this.lbl_parcela.TabIndex = 10;
            this.lbl_parcela.Text = "Digite o número de parcelas: ";
            // 
            // txt_parcela
            // 
            this.txt_parcela.Location = new System.Drawing.Point(27, 252);
            this.txt_parcela.Name = "txt_parcela";
            this.txt_parcela.Size = new System.Drawing.Size(145, 23);
            this.txt_parcela.TabIndex = 11;
            this.txt_parcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_parcela_KeyPress);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(25, 123);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(76, 15);
            this.lbl_data.TabIndex = 14;
            this.lbl_data.Text = "Digite a data:";
            // 
            // msk_data
            // 
            this.msk_data.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.msk_data.Location = new System.Drawing.Point(28, 151);
            this.msk_data.Mask = "00/00/0000";
            this.msk_data.Name = "msk_data";
            this.msk_data.Size = new System.Drawing.Size(103, 23);
            this.msk_data.TabIndex = 15;
            this.msk_data.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_realizarPagamento
            // 
            this.lbl_realizarPagamento.AutoSize = true;
            this.lbl_realizarPagamento.Location = new System.Drawing.Point(554, 123);
            this.lbl_realizarPagamento.Name = "lbl_realizarPagamento";
            this.lbl_realizarPagamento.Size = new System.Drawing.Size(158, 15);
            this.lbl_realizarPagamento.TabIndex = 16;
            this.lbl_realizarPagamento.Text = "Deseja realizar o pagamento?";
            // 
            // cmd_pagamento
            // 
            this.cmd_pagamento.Location = new System.Drawing.Point(557, 162);
            this.cmd_pagamento.Name = "cmd_pagamento";
            this.cmd_pagamento.Size = new System.Drawing.Size(179, 56);
            this.cmd_pagamento.TabIndex = 17;
            this.cmd_pagamento.Text = "Realize o pagamento";
            this.cmd_pagamento.UseVisualStyleBackColor = true;
            this.cmd_pagamento.Click += new System.EventHandler(this.cmd_pagamento_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(506, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 370);
            this.panel1.TabIndex = 18;
            // 
            // lbl_dataPagamento
            // 
            this.lbl_dataPagamento.AutoSize = true;
            this.lbl_dataPagamento.Location = new System.Drawing.Point(554, 27);
            this.lbl_dataPagamento.Name = "lbl_dataPagamento";
            this.lbl_dataPagamento.Size = new System.Drawing.Size(182, 15);
            this.lbl_dataPagamento.TabIndex = 19;
            this.lbl_dataPagamento.Text = "Digite a data que você quer pagar:";
            // 
            // msk_dataPagamento
            // 
            this.msk_dataPagamento.Location = new System.Drawing.Point(557, 64);
            this.msk_dataPagamento.Mask = "00/00/0000";
            this.msk_dataPagamento.Name = "msk_dataPagamento";
            this.msk_dataPagamento.Size = new System.Drawing.Size(89, 23);
            this.msk_dataPagamento.TabIndex = 20;
            this.msk_dataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 372);
            this.Controls.Add(this.msk_dataPagamento);
            this.Controls.Add(this.lbl_dataPagamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmd_pagamento);
            this.Controls.Add(this.lbl_realizarPagamento);
            this.Controls.Add(this.msk_data);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_parcela);
            this.Controls.Add(this.lbl_parcela);
            this.Controls.Add(this.lbl_valorJuros);
            this.Controls.Add(this.cmd_compra);
            this.Controls.Add(this.lbl_pagamentoTotal);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.txt_pagamento);
            this.Controls.Add(this.lbl_comprar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_comprar;
        private System.Windows.Forms.TextBox txt_pagamento;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Label lbl_pagamentoTotal;
        private System.Windows.Forms.Button cmd_compra;
        private System.Windows.Forms.Label lbl_valorJuros;
        private System.Windows.Forms.Label lbl_parcela;
        private System.Windows.Forms.TextBox txt_parcela;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.MaskedTextBox msk_data;
        private System.Windows.Forms.Label lbl_realizarPagamento;
        private System.Windows.Forms.Button cmd_pagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dataPagamento;
        private System.Windows.Forms.MaskedTextBox msk_dataPagamento;

    }
}

