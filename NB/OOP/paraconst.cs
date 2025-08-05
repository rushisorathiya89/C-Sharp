using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    internal class paraconst
    {
        class Student1
        {
            int rno1;
            string name1;
            public Student1()
            {

            }
            public Student1(Student1 a)
            {
                rno1 = a.rno1;
                name1 = a.name1;
            }
            static Student1()
            {
                Console.WriteLine("Static Constructor called");
            }
            public Student1(int r, string n)
            {
                rno1 = r;
                name1 = n;

            }
            public void Showdata()
            {
                Console.WriteLine(rno1);
                Console.WriteLine(name1);
            }
        }

        public static void Main(string[] args)
        {
            //Student1 a = new Student1(1, "abc");
            //a.Showdata();
            Student1[] s = new Student1[2];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student1();
            }
            Console.WriteLine("Student Details are: ");
            for (int i = 0; i < s.Length; i++)
            {
                s[i].Showdata();
            }
        }
    }
}
