using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class SeguroDeVida : ITributavel
    {
        public string Titular { get; set; }
        public double Valor { get; set; }

        public double CalculaTributo()
        {
            return (Valor * 0.1) + 42;
        }
    }
}
