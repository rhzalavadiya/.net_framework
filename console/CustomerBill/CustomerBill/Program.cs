using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            Console.Write("Enter Name : - ");
            String name = Console.ReadLine();

            Console.Write("Enter Unit : - ");
            int unit = Convert.ToInt32(Console.ReadLine());
            cust.SetName(name);
            cust.Units = unit;

            cust.CalculateTotalBill();

            Tuple<String, int,String, float> result = cust.GetData();
            Console.WriteLine("Name : - " + result.Item1);
            Console.WriteLine("Units : - " + result.Item2);
            Console.WriteLine("Claculation : - " + result.Item3);
            Console.WriteLine("Total Bill : - " + result.Item4);
            Console.ReadKey();

        }
    }
}
