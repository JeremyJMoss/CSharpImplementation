using System;
using System.Threading.Channels;
using SwishSales.HumanResources;

namespace SwishSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Bob", "Carr", 32);
            Employee e2 = new Employee("Tyrese", "Progress", 34.5);
            Employee e3 = new Employee("Margaret", "Mantis", 36);
            Console.WriteLine(e1.GetPay());
            Console.WriteLine(e1.GetFullName());
            Console.WriteLine(e2.GetPay());
            Console.WriteLine(e2.GetFullName());
            Console.WriteLine(e3.GetPay());
            Console.WriteLine(e3.GetFullName());
            e3.SetFullName("Ryan Hopefield");
            Console.WriteLine(e3.GetFullName());
            e2.SetPayRate(54);
            Console.WriteLine(e2.GetPay());
        }
    }
}