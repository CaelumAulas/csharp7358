using System;

namespace Banco.Contas
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

        public override string ToString()
        {
            return "titular: " + Titular.Nome + ", numero: " + Numero;
        }

        public override bool Equals(object obj)
        {
            if(obj is Conta)
            {
                Conta outraConta = (Conta) obj;
                if (this.Numero == outraConta.Numero)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}