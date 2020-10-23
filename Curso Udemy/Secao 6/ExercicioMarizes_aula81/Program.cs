using System;

namespace ExercicioMarizes_aula81
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
                    mat[n, k] = int.Parse(values[k]);
                }

            }


            Console.WriteLine("Digite o número a ser encontrado na matriz:");
            int num = int.Parse(Console.ReadLine());

            for (int n = 0; n < i; n++)
            {


                for (int k = 0; k < j; k++)
                {
                    if (mat[n, k] == num)
                    {
                        Console.WriteLine("O valor a esquerda é:");
                        Console.WriteLine(mat[n, k - 1]);
                        Console.WriteLine("O valor a direita é:");
                        Console.WriteLine(mat[n, k + 1]);
                        Console.WriteLine("O valor acima é:");
                        Console.WriteLine(mat[n - 1, k]);
                        Console.WriteLine("O valor abaixo é:");
                        Console.WriteLine(mat[n + 1, k]);


                    }
                }

            }




        }
    }

}

