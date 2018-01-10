using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public virtual double Bonificacao()
        {
            return Salario * 0.12;
        }
    }
}
