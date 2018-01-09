namespace OlaMundo
{
    class Conta
    {
        // atributo
        public string titular;
        public double saldo;
        public int numero;

        // método
        public bool Saque(double valor)
        {
            if(valor <= saldo)
            {
                saldo = saldo - valor;
                return true;
            }
            
            return false;
        }

        public void Deposito(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transfere(double valor, Conta contaDestino)
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
