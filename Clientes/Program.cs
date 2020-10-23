using System;
using System.Collections.Generic;


namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();

            int comando;

            do
            {

                Console.WriteLine("Digite 1 - incluir, 2 - listar, 3 - sair");
                comando = int.Parse(Console.ReadLine());

                switch (comando)

                {

                    case 1:
                        Console.WriteLine("Digite seu nome:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite seu endereço:");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Digite sua idade:");
                        int idade = int.Parse(Console.ReadLine());

                        cliente.listaCliente.Add(new Cliente(nome, endereco, idade));

                        break;

                    case 2:
                        cliente.MostraDados();

                        break;

                    case 3:
                        Console.WriteLine("Encerrando aplicação");

                        break;


                    default:
                        Console.WriteLine("Opçao invalida");
                        break;

                }

            } while (comando != 3);
        }
    }
}