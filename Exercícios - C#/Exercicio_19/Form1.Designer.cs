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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_resultados = new System.Windows.Forms.TextBox();
            this.cmd_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(16, 40);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(83, 15);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Digite o nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(19, 69);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(142, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_resultados
            // 
            this.txt_resultados.Location = new System.Drawing.Point(207, 40);
            this.txt_resultados.Multiline = true;
            this.txt_resultados.Name = "txt_resultados";
            this.txt_resultados.Size = new System.Drawing.Size(402, 220);
            this.txt_resultados.TabIndex = 2;
            // 
            // cmd_confirmar
            // 
            this.cmd_confirmar.Location = new System.Drawing.Point(19, 142);
            this.cmd_confirmar.Name = "cmd_confirmar";
            this.cmd_confirmar.Size = new System.Drawing.Size(141, 117);
            this.cmd_confirmar.TabIndex = 3;
            this.cmd_confirmar.Text = "Confirmar";
            this.cmd_confirmar.UseVisualStyleBackColor = true;
            this.cmd_confirmar.Click += new System.EventHandler(this.cmd_confirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 301);
            this.Controls.Add(this.cmd_confirmar);
            this.Controls.Add(this.txt_resultados);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_resultados;
        private System.Windows.Forms.Button cmd_confirmar;
    }
}

