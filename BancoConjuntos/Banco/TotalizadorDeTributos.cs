namespace Banco
{
    public class TotalizadorDeTributos
    {
        public double Totalizador { get; private set; }

        public void Adiciona(ITributavel tr)
        {
            Totalizador += tr.CalculaTributo();
        }
    }
}