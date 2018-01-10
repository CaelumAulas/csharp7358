using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // var jose = new Funcionario
            Funcionario jose = new Funcionario();
            jose.Nome = "Jose";
            jose.Salario = 1000;

            Gerente joao = new Gerente();
            joao.Nome = "Joao";
            joao.Salario = 2000;
            joao.Senha = "123";
            
            if(joao.Autentica("234"))
            {
                MessageBox.Show("Autenticado!");
            }

            Caixa ana = new Caixa();
            ana.Nome = "Ana";
            ana.Salario = 1500;
            ana.Ramal = "789798-9";

            Engenheiro lucas = new Engenheiro();

            CB cb = new CB();
            cb.Registra(joao);
            cb.Registra(jose);
            cb.Registra(ana);
            cb.Registra(lucas);

            MessageBox.Show("Total: " + cb.Total);
        }
    }
}
