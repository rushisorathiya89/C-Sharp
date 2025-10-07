using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public virtual double calbonus(double Salary)
        {
            return 20000.00;
        }
    }
    class Manager1 : Employee1
    {
        public override double calbonus(double Salary)
        {
            double basesal = base.calbonus(Salary);
            double calsal = Salary * 0.40;
            if (basesal > calsal)
            {
                return basesal;
            }
            else
            {
                return calsal;
            }
        }
    }
    class Tester1 : Employee1
    {
        public override double calbonus(double Salary)
        {
            return 30000.00;
        }
    }
    internal class MethodOverridingEx1
    {
        public static void Main(string[] args)
        {
            Employee1 emp = new Manager1
            {
                ID = 101,
                Name = "naveen",
                Salary = 50000,
                Designation = "c# dev",
            };
            double bonus = emp.calbonus(emp.Salary);
            Console.WriteLine($"Emp details: {emp.ID},{emp.Name},{emp.Salary},{emp.Designation}");

            Employee1 emp2 = new Manager1
            {
                ID = 215,
                Name = "Rushi",
                Salary = 50000,
                Designation = "c# dev",
            };
            bonus = emp2.calbonus(emp2.Salary);
            Console.WriteLine($"Emp 2 details: {emp2.ID},{emp2.Name},{emp2.Salary},{emp2.Designation}");
        }
    }
}

