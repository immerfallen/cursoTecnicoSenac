using System;
using System.Globalization;

namespace Pensionato_aula_71
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante[] quartos = new Estudante[10];

            Console.Write("Informe quantos estudantes alugarão os quartos: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nome do estudante: " + i);
                string name = Console.ReadLine();
                Console.WriteLine("Digite o email do estudante: " + i);
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto do estudante: " + i);
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Estudante(name, email);

            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)

                    Console.WriteLine(i + " : " + quartos[i]);

            }


        }




    }
}

