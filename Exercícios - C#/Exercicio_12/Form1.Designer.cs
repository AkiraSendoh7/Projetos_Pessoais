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
            this.cmd_confirma = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_confirma
            // 
            this.cmd_confirma.Location = new System.Drawing.Point(23, 208);
            this.cmd_confirma.Name = "cmd_confirma";
            this.cmd_confirma.Size = new System.Drawing.Size(136, 61);
            this.cmd_confirma.TabIndex = 0;
            this.cmd_confirma.Text = "Confirma";
            this.cmd_confirma.UseVisualStyleBackColor = true;
            this.cmd_confirma.Click += new System.EventHandler(this.cmd_confirma_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(20, 26);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(83, 15);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Digite o nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(23, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(136, 23);
            this.txt_nome.TabIndex = 2;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(20, 108);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(134, 15);
            this.lbl_matricula.TabIndex = 3;
            this.lbl_matricula.Text = "Digite o nº de matrícula: ";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(23, 142);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(136, 23);
            this.txt_matricula.TabIndex = 4;
            this.txt_matricula.TextChanged += new System.EventHandler(this.txt_matricula_TextChanged);
            // 
            // txt_resultados
            // 
            this.txt_resultados.Location = new System.Drawing.Point(224, 54);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.ReadOnly = true;
            this.txt_resultados.Size = new System.Drawing.Size(368, 215);
            this.txt_resultados.TabIndex = 5;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Location = new System.Drawing.Point(221, 26);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(67, 15);
            this.lbl_resultados.TabIndex = 6;
            this.lbl_resultados.Text = "Resultados: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 301);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.cmd_confirma);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_confirma;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Label lbl_resultados;
    }
}

