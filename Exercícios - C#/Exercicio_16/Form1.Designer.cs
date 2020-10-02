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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_frase = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_frase
            // 
            resources.ApplyResources(this.lbl_frase, "lbl_frase");
            this.lbl_frase.Name = "lbl_frase";
            // 
            // txt_frase
            // 
            resources.ApplyResources(this.txt_frase, "txt_frase");
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_frase_KeyDown);
            // 
            // lbl_resultados
            // 
            resources.ApplyResources(this.lbl_resultados, "lbl_resultados");
            this.lbl_resultados.Name = "lbl_resultados";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.lbl_frase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frase;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.Label lbl_resultados;
    }
}

