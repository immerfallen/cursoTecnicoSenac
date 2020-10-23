using System;

namespace notasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNotas;
            
            double media = 0;
            
            Console.WriteLine("Informe quantas notas serão calculadas:");
            numNotas = int.Parse(Console.ReadLine());

            string[] nomes = new string[numNotas];
            double[] notas = new double[numNotas];

            Console.WriteLine("Digite o nome dos alunos:");

            for (int i = 0; i<nomes.Length;i++)
            {
                nomes[i] = Console.ReadLine();

            }

            Console.WriteLine("Digite a nota dos alunos:");

            for (int i = 0; i<nomes.Length;i++)
            {
                notas[i] = double.Parse(Console.ReadLine());
                
               media = notas [i] + media;

            }

           media = media/numNotas;

            Console.WriteLine("A média foi de: {0}", media);

            for (int i = 0; i<nomes.Length;i++)
            {
                if (notas[i]>=media)    
                {   
                    Console.WriteLine("Aluno {0} acima da média, com nota de {1}", nomes[i], notas[i]);
                }

            }


        }
    }
}
