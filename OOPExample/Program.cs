using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Mr.";
            person1.middleName = "Palash";
            person1.lastName = "Mandal";

            string fullName = person1.GetFullName();
            Console.WriteLine(fullName);
            Console.ReadKey();

        }
    }
}
