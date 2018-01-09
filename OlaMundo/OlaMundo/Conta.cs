namespace OlaMundo
{
    class Conta
    {
        public string titular;
        public double saldo;
        public int numero;

        public void saque(double valor, double saldo)
        {
            if(valor <= saldo)
            {
                saldo = saldo - valor;
            }
        }
    }
}
