using System;

namespace Banco
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }

        public void Deposita(double valor)
        {
            // Saldo += valor;
            Saldo = Saldo + valor;
        }

        public void Saca(double valor)
        {
            // Saldo -= valor;
            Saldo = Saldo - valor;
        }
    }
}