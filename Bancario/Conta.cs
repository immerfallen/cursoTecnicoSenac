using System;

namespace Bancario
{
    public class Conta
    {
        public int Numero { get; private set; }
        public int DigitoVerificador { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }


        public Conta()
        {
            
        }
        public Conta(string titular, int numero)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public Conta(string titular, int numero, double depositoInicial) : this(titular, numero)
        {

           realizarDeposito(depositoInicial);
        }

        public bool realizarSaque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo = Saldo - valor - 5;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void realizarDeposito(double valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
            }
        }

        public void verExtrato()
        {
            Console.WriteLine("Seu saldo é de: R$ {0}", Saldo);

        }

        public override string ToString()
        {
            return "Conta: " + Numero + " Titular: " + Titular + ", Saldo: $ " + Saldo;
        }

    }
}
