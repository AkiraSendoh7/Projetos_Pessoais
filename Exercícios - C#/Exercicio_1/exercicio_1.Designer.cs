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
            this.cmd_calculo = new System.Windows.Forms.Button();
            this.txt_capital = new System.Windows.Forms.TextBox();
            this.lbl_capital = new System.Windows.Forms.Label();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.txt_tempo = new System.Windows.Forms.TextBox();
            this.txt_juros = new System.Windows.Forms.TextBox();
            this.lbl_juros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_calculo
            // 
            this.cmd_calculo.Location = new System.Drawing.Point(273, 147);
            this.cmd_calculo.Name = "cmd_calculo";
            this.cmd_calculo.Size = new System.Drawing.Size(174, 27);
            this.cmd_calculo.TabIndex = 0;
            this.cmd_calculo.Text = "Calcular";
            this.cmd_calculo.UseVisualStyleBackColor = true;
            this.cmd_calculo.Click += new System.EventHandler(this.cmd_calculo_Click);
            // 
            // txt_capital
            // 
            this.txt_capital.Location = new System.Drawing.Point(14, 54);
            this.txt_capital.Name = "txt_capital";
            this.txt_capital.Size = new System.Drawing.Size(173, 23);
            this.txt_capital.TabIndex = 1;
            // 
            // lbl_capital
            // 
            this.lbl_capital.AutoSize = true;
            this.lbl_capital.Location = new System.Drawing.Point(10, 24);
            this.lbl_capital.Name = "lbl_capital";
            this.lbl_capital.Size = new System.Drawing.Size(172, 15);
            this.lbl_capital.TabIndex = 2;
            this.lbl_capital.Text = "Digite o valor do Capital Inicial:";
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(10, 119);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(167, 15);
            this.lbl_tempo.TabIndex = 3;
            this.lbl_tempo.Text = "Digite o tempo do investimento:";
            // 
            // txt_tempo
            // 
            this.txt_tempo.Location = new System.Drawing.Point(14, 150);
            this.txt_tempo.Name = "txt_tempo";
            this.txt_tempo.Size = new System.Drawing.Size(173, 23);
            this.txt_tempo.TabIndex = 4;
            // 
            // txt_juros
            // 
            this.txt_juros.Location = new System.Drawing.Point(273, 54);
            this.txt_juros.Name = "txt_juros";
            this.txt_juros.Size = new System.Drawing.Size(173, 23);
            this.txt_juros.TabIndex = 5;
            // 
            // lbl_juros
            // 
            this.lbl_juros.AutoSize = true;
            this.lbl_juros.Location = new System.Drawing.Point(269, 24);
            this.lbl_juros.Name = "lbl_juros";
            this.lbl_juros.Size = new System.Drawing.Size(127, 15);
            this.lbl_juros.TabIndex = 6;
            this.lbl_juros.Text = "Digite o valor do Juros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 204);
            this.Controls.Add(this.lbl_juros);
            this.Controls.Add(this.txt_juros);
            this.Controls.Add(this.txt_tempo);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.lbl_capital);
            this.Controls.Add(this.txt_capital);
            this.Controls.Add(this.cmd_calculo);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calculo;
        private System.Windows.Forms.TextBox txt_capital;
        private System.Windows.Forms.Label lbl_capital;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.TextBox txt_tempo;
        private System.Windows.Forms.TextBox txt_juros;
        private System.Windows.Forms.Label lbl_juros;
    }
}

