using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Developer(111,"Ruchi","Developer",5,100000,"10-5-2013");
            Employee emp2 = new Hr(112, "Twinkal", "Hr", 4, 900000, "10-5-2014");

            var emp1sal=emp1.CalculateSalary();
            var emp2sal=emp2.CalculateSalary();

            Console.WriteLine("Salary of Developer:{0} Rs \nSalary of HR: {1} Rs",emp1sal,emp2sal);

            Console.Read();
        }
    }
}
