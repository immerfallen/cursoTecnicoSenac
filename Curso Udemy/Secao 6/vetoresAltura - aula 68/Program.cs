using System;
using System.Globalization;

namespace vetoresAltura
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tamanho do vetor:");

            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            Console.WriteLine("Digite os valores dos vetores:");

            for (int i = 0; i < vect.Length; i++)
            {
                Console.Write("Posição: " + i + ":");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                sum = sum + vect[i];
            }
            

            double media = sum / n;

            Console.WriteLine("O valor da média é de : " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
