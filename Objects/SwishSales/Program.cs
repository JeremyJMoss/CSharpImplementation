using System;
using SwishSales.HumanResources;

namespace SwishSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Bob", "Carr", 32);
            Employee e2 = new Employee("Blake", "Molnar", 34.5);
            Employee e3 = new Employee("Jeremy", "Moss", 36);
            Console.WriteLine(e1.GetPay());
            Console.WriteLine(e1.GetFullName());
            Console.WriteLine(e2.GetPay());
            Console.WriteLine(e2.GetFullName());
            Console.WriteLine(e3.GetPay());
            Console.WriteLine(e3.GetFullName());
        }
    }
}