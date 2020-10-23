using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de contatos a serem digitados:");

            int i = int.Parse(Console.ReadLine());

            string[] contatos = new string[i];

            for (int n = 0; n < contatos.Length; n++)
            {

                Console.WriteLine("Digite o nome do {0} contato", n);

                contatos[n] = Console.ReadLine();

            }

             Console.WriteLine("Os contatos digitados foram os seguintes:");
             
            for (int n = 0; n < contatos.Length; n++)
            {
               

                Console.WriteLine(contatos[n]);
            }
        }
    }
}
