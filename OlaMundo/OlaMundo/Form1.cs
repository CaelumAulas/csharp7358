using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = "Thiago";
            int idade = 21;
            //peso e altura
            float altura = 1.8f;
            double peso = 80.5;
            decimal preco = 89.9m;
            char sexo = 'M';

            //true e false
            bool ehFumante = false;

            // concatenação
            MessageBox.Show("O cliente é " + nome);

            // 17
            // 18.9

            double numeroDecimal = 10.9;
            // casting
            int numero = (int) numeroDecimal;

            MessageBox.Show("Numero: " + numero);
        }
    }
}
