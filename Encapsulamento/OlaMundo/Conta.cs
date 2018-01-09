namespace OlaMundo
{
    class Conta
    {
        // propriedade
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; set; }

        public bool Saque(double valor)
        {
            if(valor <= Saldo)
            {
                Saldo = Saldo - valor;
                return true;
            }
            
            return false;
        }

        public void Deposito(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transfere(Conta contaDestino, double valor)
        {
            if(Saque(valor))
            {
                contaDestino.Deposito(valor);
                return true;
            }

            return false;
        }
    }
}
