using System;
using System.Collections.Generic;
using System.Globalization;

namespace Empregados_aula_78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");

            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o id do funcionário:" + "#" + i);
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do funcionário:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o salário do funcionário:");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Digite o id do funcionário que receberá o aumento:");

            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp!= null)
            {   
                Console.WriteLine("Enter the percentage:");
                double perce = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(perce);
            }
            else 
            {
                Console.WriteLine("The employee does not exist.");
            }

            


            foreach (Employee l in list)
            {
                Console.WriteLine(l);
            }

        }
    }
}
