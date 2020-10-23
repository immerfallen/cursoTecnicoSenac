using System.Globalization;

namespace Empregados_aula_78
{
    public class Employee
    {
       

        public int Id { get; set; }
        public string Name { get; set; }    
        private double Salary { get; set; } 


        public Employee(int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;

        }


        public void IncreaseSalary(double percent)
        {
            Salary = Salary*(1+percent/100);
        }

        public  override string ToString()
        {
            return Id 
            + ", "
            + Name
            +", "
            + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}