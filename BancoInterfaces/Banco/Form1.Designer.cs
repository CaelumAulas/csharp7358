namespace Banco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDeposito = new System.Windows.Forms.Button();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(134, 122);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 26);
            this.textoTitular.TabIndex = 4;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(134, 162);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 26);
            this.textoNumero.TabIndex = 5;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(134, 216);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 26);
            this.textoSaldo.TabIndex = 6;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(134, 261);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 26);
            this.textoValor.TabIndex = 7;
            // 
            // botaoDeposito
            // 
            this.botaoDeposito.Location = new System.Drawing.Point(32, 322);
            this.botaoDeposito.Name = "botaoDeposito";
            this.botaoDeposito.Size = new System.Drawing.Size(95, 38);
            this.botaoDeposito.TabIndex = 8;
            this.botaoDeposito.Text = "Depositar";
            this.botaoDeposito.UseVisualStyleBackColor = true;
            this.botaoDeposito.Click += new System.EventHandler(this.botaoDeposito_Click);
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(147, 322);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(100, 38);
            this.botaoSaque.TabIndex = 9;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(171, 42);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(236, 28);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Escolha a conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(32, 390);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(123, 47);
            this.botaoNovaConta.TabIndex = 12;
            this.botaoNovaConta.Text = "Nova conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.botaoSaque);
            this.Controls.Add(this.botaoDeposito);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDeposito;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button button1;
    }
}

