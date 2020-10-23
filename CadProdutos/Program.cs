using System;
using System.Collections.Generic;

namespace CadProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoRepository pr = new ProdutoRepository();
            string nome, fabricante, comando;
            double preco;
            bool disponivel;


            Console.WriteLine("Cadastrando produtos:");



            do
            {
                Console.WriteLine("Digite C para cadastrar, L para listar e X para sair.");
                comando = Console.ReadLine();
                switch (comando.ToUpper())

                {

                    case "C":
                        Console.WriteLine("Digite o nome do produto:");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o fabricante do produto:");
                        fabricante = Console.ReadLine();
                        Console.WriteLine("Digite o preco do produto:");
                        preco = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite se o produto esta disponivel:");
                        disponivel = bool.Parse(Console.ReadLine());
                        pr.Insert();

                        break;

                    case "L":

                        List<Produto> lista = pr.Query();
                        foreach (Produto p in lista)
                        {
                            Console.WriteLine(p.ToString());
                        }
                        break;

                    case "X":
                        break;

                    default:
                        Console.WriteLine("Comando inválido.");
                        break;

                }

            } while (comando.ToUpper() != "X");
        }
    }
}
