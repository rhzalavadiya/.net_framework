using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_salary_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter Name : - ");
            String name=Console.ReadLine();

            Console.Write("Enter Salary : - ");
            int salary = Convert.ToInt32(Console.ReadLine());
            emp.SetName(name);
            emp.Salary = salary;

            emp.CalculateBonus();
            emp.CalculateNetSalary();

            Tuple<String,int,float,float>result=emp.GetData();
            Console.WriteLine("Name : - "+result.Item1);
            Console.WriteLine("Salary : - " + result.Item2);
            Console.WriteLine("Bonus : - " + result.Item3);
            Console.WriteLine("Net Salary : - " + result.Item4);
            Console.ReadKey();
        }
    }
}
