//Feito por AkiraSendoh7 
//https://github.com/AkiraSendoh7/Projetos_Pessoais.git
//Usar com moderação, sempre bom


namespace Exercicio_1
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
            this.lbl_frase = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.cmd_confirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_frase
            // 
            this.lbl_frase.AutoSize = true;
            this.lbl_frase.Location = new System.Drawing.Point(17, 31);
            this.lbl_frase.Name = "lbl_frase";
            this.lbl_frase.Size = new System.Drawing.Size(99, 15);
            this.lbl_frase.TabIndex = 0;
            this.lbl_frase.Text = "Digite uma frase: ";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(20, 60);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(159, 23);
            this.txt_frase.TabIndex = 1;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Location = new System.Drawing.Point(225, 31);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(67, 15);
            this.lbl_resultados.TabIndex = 2;
            this.lbl_resultados.Text = "Resultados: ";
            // 
            // txt_resultados
            // 
            this.txt_resultados.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultados.Location = new System.Drawing.Point(228, 60);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.ReadOnly = true;
            this.txt_resultados.Size = new System.Drawing.Size(235, 172);
            this.txt_resultados.TabIndex = 3;
            // 
            // cmd_confirma
            // 
            this.cmd_confirma.Location = new System.Drawing.Point(20, 121);
            this.cmd_confirma.Name = "cmd_confirma";
            this.cmd_confirma.Size = new System.Drawing.Size(159, 110);
            this.cmd_confirma.TabIndex = 4;
            this.cmd_confirma.Text = "Confirma";
            this.cmd_confirma.UseVisualStyleBackColor = true;
            this.cmd_confirma.Click += new System.EventHandler(this.cmd_confirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.cmd_confirma);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.lbl_frase);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Button cmd_confirma;
    }
}

