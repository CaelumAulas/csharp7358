using System;

namespace Banco
{
    public abstract class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        public virtual void Deposita(double valor)
        {
            // Saldo += valor;
            Saldo = Saldo + valor;
        }

        public abstract void Saca(double valor);
    }
}