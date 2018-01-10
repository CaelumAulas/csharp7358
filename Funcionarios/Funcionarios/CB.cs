using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    class CB
    {
        public double Total { get; private set; }

        // bonificacao
        // funcionario
        public void Registra(Funcionario func)
        {
            Total += func.Bonificacao();
        }
    }
}
