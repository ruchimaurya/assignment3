using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts
{
    class Hr:Employee
    {
        static double basicSalary = 8000;
     

        public Hr(int id, string name, string designation, int experiance, double annualSalary, string joinDate)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.experiance = experiance;
            this.annualSalary = annualSalary;
            this.joinDate = joinDate;
        }
        public override double CalculateSalary()
        {
            var salary = basicSalary + (experiance * 1000);
            return salary;
        }

    }
}
