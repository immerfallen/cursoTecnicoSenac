using System;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();

            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOME: " + aluno.Nome );
            Console.WriteLine("MÉDIA " + aluno.Media().ToString("F2"));
           
            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO.");
                Console.WriteLine("FALTARAM : " + aluno.NotaRestante().ToString("F2"));
            }


        }
    }
}
