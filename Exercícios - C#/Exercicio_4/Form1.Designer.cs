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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_confirma
            // 
            this.cmd_confirma.Location = new System.Drawing.Point(26, 199);
            this.cmd_confirma.Name = "cmd_confirma";
            this.cmd_confirma.Size = new System.Drawing.Size(97, 21);
            this.cmd_confirma.TabIndex = 0;
            this.cmd_confirma.Text = "Confirma";
            this.cmd_confirma.UseVisualStyleBackColor = true;
            this.cmd_confirma.Click += new System.EventHandler(this.cmd_confirma_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(26, 101);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(97, 20);
            this.txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(151, 101);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(99, 20);
            this.txtMes.TabIndex = 4;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(282, 101);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(96, 20);
            this.txtAno.TabIndex = 5;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(23, 85);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(26, 13);
            this.lblDia.TabIndex = 6;
            this.lblDia.Text = "Dia:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(148, 85);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mês";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(279, 85);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 8;
            this.lblAno.Text = "Ano:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(151, 199);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(227, 20);
            this.txtR.TabIndex = 9;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(148, 183);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(63, 13);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "Resultados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 261);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmd_confirma);
            this.Name = "Form1";
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_confirma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lbl_resultado;
    }
}

