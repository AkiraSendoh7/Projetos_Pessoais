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
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.cmd_confirmar = new System.Windows.Forms.Button();
            this.msk_dia = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(194, 33);
            this.txt_resultado.Multiline = true;
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(400, 126);
            this.txt_resultado.TabIndex = 0;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(21, 33);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(76, 15);
            this.lbl_data.TabIndex = 2;
            this.lbl_data.Text = "Digite a data:";
            // 
            // cmd_confirmar
            // 
            this.cmd_confirmar.Location = new System.Drawing.Point(24, 117);
            this.cmd_confirmar.Name = "cmd_confirmar";
            this.cmd_confirmar.Size = new System.Drawing.Size(137, 42);
            this.cmd_confirmar.TabIndex = 3;
            this.cmd_confirmar.Text = "Confirmar";
            this.cmd_confirmar.UseVisualStyleBackColor = true;
            this.cmd_confirmar.Click += new System.EventHandler(this.cmd_confirmar_Click);
            // 
            // msk_dia
            // 
            this.msk_dia.Location = new System.Drawing.Point(24, 65);
            this.msk_dia.Mask = "00/00/0000";
            this.msk_dia.Name = "msk_dia";
            this.msk_dia.Size = new System.Drawing.Size(83, 23);
            this.msk_dia.TabIndex = 4;
            this.msk_dia.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 204);
            this.Controls.Add(this.msk_dia);
            this.Controls.Add(this.cmd_confirmar);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_resultado);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Button cmd_confirmar;
        private System.Windows.Forms.MaskedTextBox msk_dia;
    }
}

