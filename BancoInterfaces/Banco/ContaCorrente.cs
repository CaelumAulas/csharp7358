using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            Saldo = Saldo + (valor - 0.1);
        }

        public override void Saca(double valor)
        {
            Saldo = Saldo - (valor + 0.05);
        }

        public double CalculaTributo()
        {
            return Saldo * 0.1;
        }
    }
}
