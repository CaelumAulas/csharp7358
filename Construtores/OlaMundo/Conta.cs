namespace OlaMundo
{
    class Conta
    {
        // propriedade
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public int Numero { get; set; }
     
        public Conta()
        {

        }
        
        public Conta(int numero, double saldoInicial)
        {
            this.Saldo = saldoInicial;
            this.Numero = numero;
        }

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
            Saldo = Saldo + valor;
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
