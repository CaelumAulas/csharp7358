using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroContas : Form
    {
        private Form1 form1;

        public FormCadastroContas(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void FormCadastroContas_Load(object sender, EventArgs e)
        {

        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente(textoTitular.Text);
            Conta novaConta = new ContaPoupanca();
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);
            novaConta.Titular = novoCliente;
            
            form1.AdicionaConta(novaConta);

            MessageBox.Show("Conta adicionada!");
            Dispose();
        }
    }
}
