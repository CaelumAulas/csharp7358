using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("entrada.txt", FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            string linha = reader.ReadLine();

            while(linha != null)
            {
                MessageBox.Show(linha);
                linha = reader.ReadLine();
            }

            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("saida.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine("Boa tarde");

            writer.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String curso1 = "fn13";
            curso1.Replace("13", "11");
            MessageBox.Show("contem fn? " + curso1.Contains("fn"));
            MessageBox.Show(curso1.Replace("13", "11"));
            // curso1 = curso1.ToUpper();
            // MessageBox.Show(curso1.ToUpper());
        }
    }
}
