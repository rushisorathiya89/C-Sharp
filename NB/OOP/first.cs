using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    public class Employee
    {
        int empId;
        string eName;
        double salary;
        public void getData(int empId,string eName,double salary)
        {
            this.empId = empId;
            this.eName = eName;
            this.salary = salary;
        }

        public void showData()
        {
            Console.WriteLine("emp id: " + empId);
            Console.WriteLine("emp name: " + eName);
            Console.WriteLine("emp slary: " + salary);
        }

        public double getSalary()
        {
            return salary;
        }
    }
    internal class first
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getData(1,"Rushi",150000);
            //e1.showData();

            Employee e2 = new Employee();
            e2.getData(2,"Virus",12);
            //e2.showData();

            if(e1.getSalary()> e2.getSalary())
            {
                Console.WriteLine(""
            }
        }
    }
}
