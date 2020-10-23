using System;
using System.Globalization;

namespace AumentoSalario
{
    class Program
    {
        static void Main(string[] args)
        {

            Salario func = new Salario();

            Console.WriteLine("Digite o nome do funcionário:");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário funcionário:");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o imposto:");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine("");
            Console.WriteLine("Deseja aumentar o percentual do salário em qual %?");
            double percent = double.Parse(Console.ReadLine());
            func.AumentarSalario(percent);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + func);



        }
    }
}
