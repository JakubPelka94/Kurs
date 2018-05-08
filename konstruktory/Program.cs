using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person(2,"Kazik");
            Person p3 = new Person(3, "Mordo", "Moja");
            Person p4 = new Person(3, "Mordo", "Moja", "Katowice", 19, "Male");
                
        }
    }
}
