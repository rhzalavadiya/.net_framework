using System;
namespace BasicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nm, city;
            Int32 age, num1;
            double num2;
            Console.WriteLine("Hello Student \nName :- Zalavadiya Rupali \nCity :- Ahmedabad \nAge :- 22");
            //get value from user
            Console.Write("Enter Name :- ");
            nm = Console.ReadLine();

            Console.Write("Enter City :- ");
            city = Console.ReadLine();

            Console.Write("Enter Age :- ");
            age =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(string.Format("Name : {0}\nCity : {1}\nAge :{2}",nm,city,age));
            //Arithmetic
            Console.Write("Enter The Value of Number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Value of Number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addtion  : "+(num1+num2));
            Console.WriteLine("Subtraction  : " + (num1 - num2));
            Console.WriteLine("Multipliction  : " + (num1 * num2));
            Console.WriteLine("Division  : " + Convert.ToSingle((num1 / num2)));
            Console.ReadKey();
        }
    }
}
