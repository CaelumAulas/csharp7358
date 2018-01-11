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
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];
            

            Cliente joao = new Cliente("Joao");
            Conta contaJoao = new ContaPoupanca();
            contaJoao.Numero = 345;
            contaJoao.Titular = joao;
            AdicionaConta(contaJoao);

            Cliente maria = new Cliente("Maria");
            Conta contaMaria = new ContaCorrente();
            contaMaria.Numero = 567;
            contaMaria.Titular = maria;
            AdicionaConta(contaMaria);

            Cliente jose = new Cliente("Jose");
            Conta contaJose = new ContaPoupanca();
            contaJose.Numero = 890;
            contaJose.Titular = jose;
            AdicionaConta(contaJose);
        }

        public void AdicionaConta(Conta novaConta)
        {
            contas[numeroDeContas] = novaConta;
            numeroDeContas++;
            comboContas.Items.Add("titular: " + novaConta.Titular.Nome);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);

            int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indice];
            contaSelecionada.Deposita(valor);

            textoSaldo.Text = contaSelecionada.Saldo.ToString();
            MessageBox.Show("Deposito realizado");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);

            int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indice];

            contaSelecionada.Saca(valor);
            textoSaldo.Text = contaSelecionada.Saldo.ToString();
            MessageBox.Show("Perdeu playboy!");
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indice];
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroContas formCadastro = new FormCadastroContas(this);
            formCadastro.Show();
        }
    }
}
