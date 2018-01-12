using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente : Conta, ITributavel
    {
        private static int totalDecontas;

        public ContaCorrente()
        {
            totalDecontas++;
        }

        public static int Total()
        {
            return totalDecontas;
        }

        public override void Deposita(double valor)
        {
            Saldo = Saldo + (valor - 0.1);
        }

        public override void Saca(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException();
            }

            if(Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }

            Saldo = Saldo - (valor + 0.05);
        }

        public double CalculaTributo()
        {
            return Saldo * 0.1;
        }
    }
}
