using System;

namespace Matrizes_aula80
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas linhas terá a matriz: ");

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantas colunas terá a matriz: ");

            int j = int.Parse(Console.ReadLine());

            int[,] mat = new int[i, j];

            Console.WriteLine("Digite os valores da matriz: ");

            for (int n = 0; n < i; n++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int k = 0; k < j; k++)
                {
                    mat[n, k] = int.Parse(values[j]);
                }

            }
             Console.WriteLine("Diagonal principal: ");
            for (int n = 0; n < i; n++)
            {
                for (int k = 0; k < j; k++)
                {
                    if (n == k)
                    {
                        Console.WriteLine(mat[n, k]);
                    }

                }
            }

             int sum = 0;

             for (int n = 0; n < i; n++)
            {
                for (int k = 0; k < j; k++)
                {
                   
                    if (mat[n,k]<0)
                    {
                        sum = sum+1;
                    }
                }

            }

            Console.WriteLine("Total de números negativos:");
            Console.WriteLine(sum);

        }
    }

}