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

        private void button3_Click(object sender, EventArgs e)
        {
            int idade = 19;

            if(idade > 18)
            {
                MessageBox.Show("Você pode entrar na balada");
            }
            else
            {
                MessageBox.Show("Você nao pode");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // repetição; laços
            // while, for

            for(int numero = 1; numero <= 100; numero++)
            {
                MessageBox.Show("numero: " + numero);
            }

            int idade = 14;

            // while

            while(idade < 18)
            {
                MessageBox.Show("Nao pode");
                idade++;
            }

            for( ; idade < 18; idade++)
            {
                MessageBox.Show("Nao pode");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 1; i <= 1000; i++)
            {
                total = i + total;
            }
            MessageBox.Show("Soma de 1 a 1000: " + total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int n = 1;  n <= 100; n++)
            {
                if(n % 3 == 0 || n % 4 == 0)
                {
                    MessageBox.Show("Multiplo: " + n);
                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for(int i = 1; i <= 10; i++)
            {
                fatorial = fatorial * i; 
                MessageBox.Show("Fatorial: " + fatorial);
            }
        }
    }
}
