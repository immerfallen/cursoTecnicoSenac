using System;

namespace geradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informar seu primeiro nome: ");

            string nome = Console.ReadLine();

            Console.Write("Informar seu ano de nascimento: "); /* Sei que deveria ser inserido a data completa , mas ainda estou aprendendo a usar o DateTime e o tipo TimeSpan. Também sei que deveria fazer o teste se a data do aniverário já passou ou não e subtrair 1 caso ainda não.*/

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
