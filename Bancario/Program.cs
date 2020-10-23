using System;
using System.Globalization;

namespace Bancario
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta contaBancaria;                     
            
            string comando;
            double valor;

            Console.Write("Digite seu nome: ");
            string titular = Console.ReadLine();
            Console.Write("Digite sua conta bancária: ");
            int numero = int.Parse(Console.ReadLine());                  
           
            Console.WriteLine("Haverá depósito inicial? S - Sim, N - Não.");
            string resp = Console.ReadLine();

            if (resp == "s" || resp == "S")
            {
                Console.Write("Qual o valor do depósito inicial? ");
                double depositoInicial = double.Parse(Console.ReadLine());
                contaBancaria = new Conta(titular, numero, depositoInicial);                
            }
            else 
            {
                contaBancaria = new Conta(titular, numero);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);
            do
            {
                Console.WriteLine("Digite a operação [d-depósito; s-saque; e-extrato; x-sair]");
                comando = Console.ReadLine();
                switch (comando)
                {
                    case "d":
                        Console.WriteLine("Digite o valor a depositar:");
                        valor = double.Parse(Console.ReadLine());
                        contaBancaria.realizarDeposito(valor);
                        Console.WriteLine("Dados da conta:");
                       Console.WriteLine(contaBancaria);
                        {
                            break;
                        }
                    case "s":
                        Console.WriteLine("Digite o valor a sacar:");
                        valor = double.Parse(Console.ReadLine());
                        if (contaBancaria.realizarSaque(valor) == false)
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        else
                        {
                            Console.WriteLine("Dados da conta:");
                            Console.WriteLine(contaBancaria);
                        }
                        break;
                    case "e":
                        contaBancaria.verExtrato();
                        break;
                    case "x":
                        Console.WriteLine("Encerrando aplicação.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (comando != "x");
        }
    }
}
