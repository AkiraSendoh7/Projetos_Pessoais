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
            this.lbl_dia = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.cmd_confirma = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(16, 28);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(31, 15);
            this.lbl_dia.TabIndex = 0;
            this.lbl_dia.Text = "Dia: ";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(19, 58);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(131, 23);
            this.txt_dia.TabIndex = 1;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Location = new System.Drawing.Point(196, 28);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(31, 15);
            this.lbl_mes.TabIndex = 2;
            this.lbl_mes.Text = "Mês:";
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(199, 58);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(131, 23);
            this.txt_mes.TabIndex = 3;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(372, 58);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(131, 23);
            this.txt_ano.TabIndex = 4;
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(369, 28);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(30, 15);
            this.lbl_ano.TabIndex = 5;
            this.lbl_ano.Text = "Ano:";
            // 
            // cmd_confirma
            // 
            this.cmd_confirma.Location = new System.Drawing.Point(19, 105);
            this.cmd_confirma.Name = "cmd_confirma";
            this.cmd_confirma.Size = new System.Drawing.Size(484, 22);
            this.cmd_confirma.TabIndex = 7;
            this.cmd_confirma.Text = "Confirma";
            this.cmd_confirma.UseVisualStyleBackColor = true;
            this.cmd_confirma.Click += new System.EventHandler(this.cmd_confirma_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(19, 158);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(484, 135);
            this.txt_result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 335);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.cmd_confirma);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.lbl_dia);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Button cmd_confirma;
        private System.Windows.Forms.TextBox txt_result;
    }
}

