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
            this.cmd_frase = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.cmd_confirmar = new System.Windows.Forms.Button();
            this.lbl_letra = new System.Windows.Forms.Label();
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_frase
            // 
            this.cmd_frase.AutoSize = true;
            this.cmd_frase.Location = new System.Drawing.Point(18, 34);
            this.cmd_frase.Name = "cmd_frase";
            this.cmd_frase.Size = new System.Drawing.Size(36, 13);
            this.cmd_frase.TabIndex = 0;
            this.cmd_frase.Text = "Frase:";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(20, 59);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(153, 20);
            this.txt_frase.TabIndex = 1;
            // 
            // txt_resultados
            // 
            this.txt_resultados.Location = new System.Drawing.Point(227, 34);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.Size = new System.Drawing.Size(313, 249);
            this.txt_resultados.TabIndex = 2;
            // 
            // cmd_confirmar
            // 
            this.cmd_confirmar.Location = new System.Drawing.Point(21, 199);
            this.cmd_confirmar.Name = "cmd_confirmar";
            this.cmd_confirmar.Size = new System.Drawing.Size(153, 84);
            this.cmd_confirmar.TabIndex = 3;
            this.cmd_confirmar.Text = "Confirmar";
            this.cmd_confirmar.UseVisualStyleBackColor = true;
            this.cmd_confirmar.Click += new System.EventHandler(this.cmd_confirmar_Click);
            // 
            // lbl_letra
            // 
            this.lbl_letra.AutoSize = true;
            this.lbl_letra.Location = new System.Drawing.Point(21, 113);
            this.lbl_letra.Name = "lbl_letra";
            this.lbl_letra.Size = new System.Drawing.Size(34, 13);
            this.lbl_letra.TabIndex = 4;
            this.lbl_letra.Text = "Letra:";
            // 
            // txt_letra
            // 
            this.txt_letra.Location = new System.Drawing.Point(21, 140);
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(152, 20);
            this.txt_letra.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 319);
            this.Controls.Add(this.txt_letra);
            this.Controls.Add(this.lbl_letra);
            this.Controls.Add(this.cmd_confirmar);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.cmd_frase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmd_frase;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Button cmd_confirmar;
        private System.Windows.Forms.Label lbl_letra;
        private System.Windows.Forms.TextBox txt_letra;
    }
}

