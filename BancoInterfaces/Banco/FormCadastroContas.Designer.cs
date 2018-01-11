namespace Banco
{
    partial class FormCadastroContas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(138, 37);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 26);
            this.textoTitular.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(138, 81);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 26);
            this.textoNumero.TabIndex = 3;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(138, 151);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(100, 36);
            this.botaoCadastrar.TabIndex = 4;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // FormCadastroContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroContas";
            this.Text = "FormCadastroContas";
            this.Load += new System.EventHandler(this.FormCadastroContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Button botaoCadastrar;
    }
}