using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaInvestimento : Conta
    {
        public override void Saca(double valor)
        {
            Saldo = Saldo + (valor - 1);
        }
    }
}
