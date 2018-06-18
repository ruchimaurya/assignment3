using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConcepts
{
     abstract class Employee
    {
        protected virtual int id { get; set; }
        protected virtual string name { get; set; }
        protected virtual string designation { get; set; }
        protected virtual int experiance { get; set; }
        protected virtual double annualSalary { get; set; }
        protected virtual string joinDate { get; set; }

        abstract public double CalculateSalary();
        
     
    }
}
