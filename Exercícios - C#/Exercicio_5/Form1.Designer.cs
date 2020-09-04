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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.lbl_taxa = new System.Windows.Forms.Label();
            this.lstnome = new System.Windows.Forms.ListBox();
            this.lstvalorinicial = new System.Windows.Forms.ListBox();
            this.lstvaloratual = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmd_confirma
            // 
            this.cmd_confirma.Location = new System.Drawing.Point(22, 166);
            this.cmd_confirma.Name = "cmd_confirma";
            this.cmd_confirma.Size = new System.Drawing.Size(179, 86);
            this.cmd_confirma.TabIndex = 0;
            this.cmd_confirma.Text = "Confirma";
            this.cmd_confirma.UseVisualStyleBackColor = true;
            this.cmd_confirma.Click += new System.EventHandler(this.cmd_confirma_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(19, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 14);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(258, 48);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(219, 22);
            this.txtValor.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(255, 31);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(38, 14);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor:";
            // 
            // txt_taxa
            // 
            this.txt_taxa.Location = new System.Drawing.Point(22, 109);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(170, 22);
            this.txt_taxa.TabIndex = 5;
            // 
            // lbl_taxa
            // 
            this.lbl_taxa.AutoSize = true;
            this.lbl_taxa.Location = new System.Drawing.Point(19, 92);
            this.lbl_taxa.Name = "lbl_taxa";
            this.lbl_taxa.Size = new System.Drawing.Size(34, 14);
            this.lbl_taxa.TabIndex = 6;
            this.lbl_taxa.Text = "Taxa:";
            // 
            // lstnome
            // 
            this.lstnome.FormattingEnabled = true;
            this.lstnome.ItemHeight = 14;
            this.lstnome.Location = new System.Drawing.Point(258, 109);
            this.lstnome.Name = "lstnome";
            this.lstnome.Size = new System.Drawing.Size(92, 144);
            this.lstnome.TabIndex = 7;
            // 
            // lstvalorinicial
            // 
            this.lstvalorinicial.FormattingEnabled = true;
            this.lstvalorinicial.ItemHeight = 14;
            this.lstvalorinicial.Location = new System.Drawing.Point(377, 109);
            this.lstvalorinicial.Name = "lstvalorinicial";
            this.lstvalorinicial.Size = new System.Drawing.Size(92, 144);
            this.lstvalorinicial.TabIndex = 8;
            // 
            // lstvaloratual
            // 
            this.lstvaloratual.FormattingEnabled = true;
            this.lstvaloratual.ItemHeight = 14;
            this.lstvaloratual.Location = new System.Drawing.Point(504, 108);
            this.lstvaloratual.Name = "lstvaloratual";
            this.lstvaloratual.Size = new System.Drawing.Size(92, 144);
            this.lstvaloratual.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 281);
            this.Controls.Add(this.lstvaloratual);
            this.Controls.Add(this.lstvalorinicial);
            this.Controls.Add(this.lstnome);
            this.Controls.Add(this.lbl_taxa);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmd_confirma);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_confirma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.Label lbl_taxa;
        private System.Windows.Forms.ListBox lstnome;
        private System.Windows.Forms.ListBox lstvalorinicial;
        private System.Windows.Forms.ListBox lstvaloratual;
    }
}

