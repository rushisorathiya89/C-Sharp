using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    class P
    {
        public virtual void show()
        {
            Console.WriteLine("Parent class");
        }
    }
    class C : P
    {
        public override void show()
        {
            P obj=new P();
            obj.show();
            Console.WriteLine("Child class");
        }
    }
    internal class Methodoverrinding
    {
        static void Main(string[] args)
        {
            P pobj;
            C cobj = new C();
            pobj = cobj;
            pobj.show();
            cobj.show();
        }
    }
}
