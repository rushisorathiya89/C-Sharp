using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    class A
    {
        int x;
        public A(int x)
        {
            Console.WriteLine("Constructer from child A.");
            this.x = x;
        }
        public void methodA1()
        {
            Console.WriteLine("Method-1 From Base A");
            Console.WriteLine("value of x is: " + x);
        }
        public void methodA2()
        {
            Console.WriteLine("Method-2 from Base A");
        }
        public int X
        {
            get { return X; }
            set { X = value; }
        }
    }

    class B : A
    {
        int y;
        public B(int x,int y) : base(x)
        {
            Console.WriteLine("Constructer from child B.");
            this.y = y;
        }
        public void methodB1()
        {
            methodA2();
            Console.WriteLine("Method-1 From Derived B");
            Console.WriteLine("Value of y is : " + y);
        }

        public int Y
        {
            get { return Y;  }
            set { Y = value; }
        }

        //public void calcAvg()
        //{
        //    double avg=(double)(x+y)/2;
        //    Console.WriteLine("Average is: " + avg);
        //}
    }
    internal class Inheritance
    {
        public static void Main()
        {
            B obj = new B(10,20);
            obj.methodA1();
            obj.methodB1();
           double avg =(obj.X + obj.Y)/2;
            Console.WriteLine("Average is: " + avg);
        }
    }
}
/*
 Types of inheritance:
1.Single
2.Multi-level
3.hierarchical
4.Multiple
5.Hybrid
 */