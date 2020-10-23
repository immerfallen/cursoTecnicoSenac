using System;

namespace geradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informar seu primeiro nome: ");

            string nome = Console.ReadLine();

            Console.Write("Informar seu ano de nascimento: ");

            int ano = int.Parse(Console.ReadLine());

            int idade = 2019 - ano;

            if (idade > 18)
            {

                Console.WriteLine("A sugestão de senha é:" + idade + nome);
            }
            else
            {
                Console.WriteLine("A sugestão de senha é:" + nome + idade);
            }
        }
    }
}
