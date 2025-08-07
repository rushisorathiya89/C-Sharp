using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    internal class properties
    {
        class student
        {
            private string firstname;
            private string lastname;

            //1st way
            public string getFirstname()
            {
                return firstname;
            }

            public void setFirstname(string fstname)
            {
                firstname = fstname;
            }

            // 2nd wins
            public string FirstName
            {
                get { return firstname; }
                set { firstname = value; }
            }
            static void Main(string[] args)
            {
                student obj = new student();
                //1st
                obj.setFirstname("Rushi");
                Console.WriteLine(obj.getFirstname());

                obj.FirstName = "Rushi";
                Console.WriteLine(obj.FirstName);
            }
        }
    }
}
