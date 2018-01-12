using Banco.Contas;
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
        private List<Conta> contas;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new List<Conta>();

            Cliente joao = new Cliente("Joao");
            ContaCorrente contaJoao = new ContaCorrente();
            contaJoao.Numero = 345;
            contaJoao.Titular = joao;
            AdicionaConta(contaJoao);

            Cliente maria = new Cliente("Maria");
            ContaCorrente contaMaria = new ContaCorrente();
            contaMaria.Numero = 567;
            contaMaria.Titular = maria;
            AdicionaConta(contaMaria);

            Cliente jose = new Cliente("Jose");
            ContaCorrente contaJose = new ContaCorrente();
            contaJose.Numero = 890;
            contaJose.Titular = jose;
            AdicionaConta(contaJose);
        }

        public void AdicionaConta(Conta novaConta)
        {
            contas.Add(novaConta);
            comboContas.Items.Add(novaConta);
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

            try
            {
                contaSelecionada.Saca(valor);
                // emite as notas
                MessageBox.Show("Saque realizado com sucesso");
            }
            catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo insuficiente");
                // mostra saldo
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Valor negativo");
                // mostra teclado
            }

            textoSaldo.Text = contaSelecionada.Saldo.ToString();
            MessageBox.Show("Até logo");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente joao1 = new Cliente("Joao");
            Conta contaJoao1 = new ContaCorrente();
            contaJoao1.Numero = 123;
            contaJoao1.Deposita(100);

            Cliente joao2 = new Cliente("Joao");
            Conta contaJoao2 = new ContaPoupanca();
            contaJoao2.Numero = 123;
            contaJoao2.Deposita(100);

            if(contaJoao1.Equals(contaJoao2))
            {
                MessageBox.Show("Iguais");
            }
            else
            {
                MessageBox.Show("Diferentes");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente lucas = new Cliente("Lucas");
            Conta c1 = new ContaCorrente();
            c1.Titular = lucas;
            c1.Numero = 123;

            Conta c2 = new ContaCorrente();
            c2.Numero = 145;

            Cliente joao = new Cliente("Joao");
            Conta c3 = new ContaCorrente();
            c3.Titular = joao;
            c3.Numero = 123;

            List<Conta> contas = new List<Conta>();
            contas.Add(c1);
            contas.Add(c2);
            
            MessageBox.Show("Tamanho: " + contas.Count);
            contas.Remove(c3);
            MessageBox.Show("Tamanho: " + contas.Count);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente lucas = new Cliente("Lucas");
            Conta c1 = new ContaCorrente();
            c1.Titular = lucas;
            c1.Numero = 123;

            Cliente ana = new Cliente("Ana");
            Conta c2 = new ContaCorrente();
            c2.Titular = ana;
            c2.Numero = 145;

            Cliente joao = new Cliente("Joao");
            Conta c3 = new ContaCorrente();
            c3.Titular = joao;
            c3.Numero = 123;

            Dictionary<string, Conta> nomeConta = new Dictionary<string, Conta>();
            nomeConta.Add(c1.Titular.Nome, c1);
            nomeConta.Add("ana", c2);
            nomeConta.Add("joao", c3);

            Conta recuparada = nomeConta["lucas"];
            MessageBox.Show("Conta: " + recuparada);

            foreach(KeyValuePair<string, Conta> par in nomeConta)
            {
                MessageBox.Show("Chave: " + par.Key + ", Valor: " + par.Value);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Cliente lucas = new Cliente("Lucas");
            Conta c1 = new ContaCorrente();
            c1.Titular = lucas;
            c1.Numero = 123;
            c1.Deposita(501);

            Cliente ana = new Cliente("Ana");
            Conta c2 = new ContaCorrente();
            c2.Titular = ana;
            c2.Numero = 145;
            c2.Deposita(400);

            Cliente joao = new Cliente("Joao");
            Conta c3 = new ContaCorrente();
            c3.Titular = joao;
            c3.Numero = 567;
            c3.Deposita(600);

            Cliente zeca = new Cliente("Zeca");
            Conta c4 = new ContaCorrente();
            c4.Titular = ana;
            c4.Numero = 145;
            c4.Deposita(300);

            List<Conta> contas = new List<Conta>();
            contas.Add(c1);
            contas.Add(c2);
            contas.Add(c3);
            contas.Add(c4);

            double soma = 0;
            foreach(Conta atual in contas)
            {
                soma = soma + atual.Saldo;
            }

            MessageBox.Show("Soma dos Saldos: " + soma);

            var somaDosSaldos = contas.Sum(c => c.Saldo);
            var maximo = contas.Max(c => c.Saldo);
            var media = contas.Average(c => c.Saldo);
            MessageBox.Show("Maximo: " + maximo);

            var maioresQ500 = from c in contas
                              where c.Saldo > 500
                              orderby  c.Titular.Nome descending
                              orderby c.Saldo descending
                              select new { c.Titular.Nome, c.Saldo };

            /*List<Conta> saldoMaiorQue500 = new List<Conta>();
            foreach (Conta atual in contas)
            {
                if (atual.Saldo >= 500)
                {
                    saldoMaiorQue500.Add(atual);
                }
            }*/

            // lambda
            var saldoMaiorQue500 = contas.Where(c => c.Saldo >= 500);
            

            foreach (Conta atual in saldoMaiorQue500)
            {
                MessageBox.Show("Conta: " + atual);
            }

        }
    }
}
