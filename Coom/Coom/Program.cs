using System;
using Coom.Employees;

namespace Coom
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee mary = new Employee();
            mary.setId(1);
            mary.setName("Mary Ann");
            Console.WriteLine("Hello " + mary.getName());
            mary.info();
        }
    }
}
