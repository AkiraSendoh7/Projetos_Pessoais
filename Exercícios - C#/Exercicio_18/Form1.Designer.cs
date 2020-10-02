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
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.cmd_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(20, 25);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(84, 15);
            this.lbl_texto.TabIndex = 0;
            this.lbl_texto.Text = "Digite o texto: ";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(23, 57);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(182, 23);
            this.txt_frase.TabIndex = 1;
            this.txt_frase.TextChanged += new System.EventHandler(this.txt_frase_TextChanged);
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Location = new System.Drawing.Point(242, 25);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(67, 15);
            this.lbl_resultados.TabIndex = 2;
            this.lbl_resultados.Text = "Resultados: ";
            // 
            // txt_resultados
            // 
            this.txt_resultados.Location = new System.Drawing.Point(245, 57);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_resultados.Size = new System.Drawing.Size(323, 169);
            this.txt_resultados.TabIndex = 3;
            // 
            // cmd_confirmar
            // 
            this.cmd_confirmar.Location = new System.Drawing.Point(23, 123);
            this.cmd_confirmar.Name = "cmd_confirmar";
            this.cmd_confirmar.Size = new System.Drawing.Size(182, 103);
            this.cmd_confirmar.TabIndex = 4;
            this.cmd_confirmar.Text = "Confirmar";
            this.cmd_confirmar.UseVisualStyleBackColor = true;
            this.cmd_confirmar.Click += new System.EventHandler(this.cmd_confirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 258);
            this.Controls.Add(this.cmd_confirmar);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.lbl_texto);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Button cmd_confirmar;
    }
}

