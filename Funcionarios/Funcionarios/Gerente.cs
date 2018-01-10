using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Gerente : Funcionario
    {
        public string Senha { get; set; }

        public bool Autentica(string senha)
        {
            if(senha == Senha)
            {
                return true;
            }

            return false;
        }

        public override double Bonificacao()
        {
            return base.Bonificacao() + 500;
        }
    }
}
