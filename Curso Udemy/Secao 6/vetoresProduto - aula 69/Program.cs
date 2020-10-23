using System;
using System.Globalization;

namespace vetoresProduto___aula_69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quanto produtos serão cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("Digite o nome do produto: " + i);
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: " + i);
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                produtos[i] = new Produto{Name=name, Price=price};

            }

            double sum = 0;

             for (int i = 0; i < produtos.Length; i++)
            {
                sum = sum + produtos[i].Price;

            }

            Console.WriteLine(sum);

           double media = sum/n;

           Console.WriteLine("Média de preços é de: " + media, ("F2",CultureInfo.InvariantCulture));
        }
    }
}
