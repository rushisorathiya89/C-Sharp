using NB.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    /*
     * to access private members ofc class from outside
     * Encapsulation ->accessors
     * Set and Get
     * intermediate - only to transfer the data
     * set property-> is used to set the values
     * get property -> is used to retrieve the value
     * 
     * types:
     * read-write property
     * read-only property
     * write-only property
     * auto implemented property
     
     */
    public class Demo1
    {
        int x;
        int y;

        public int X
        {
            //1 .read-write property
            set { x = value; }
            get { return x; }
        }

        public int Y
        {
            set { y = value; }
            get { return y; }
        }
    }

    public class Demo2
    {
        //read-only property
        int x, y;
        public Demo2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

    }

    public class Demo3
    {
        int x, y;
        public Demo3(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            set { X = value; }
        }
        public int Y
        {
            set { Y = value; }
        }
    }

    internal class Properties
    {
        public static void Main(string[] args)
        {


            //Demo1 d = new Demo1();
            //Demo2 demo = new Demo2(100, 200);
            //d.X = 10;
            //d.Y  = 20;
            //demo.X = 150;
            Demo3 demo3 = new Demo3(100, 200);
            Console.WriteLine(demo.X);
            Console.WriteLine(demo.Y);

        }
    }
}


