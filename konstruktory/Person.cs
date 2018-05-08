using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktory
{
    class Person
    {
        int id;
        string fname;
        string lname;
        string adress;
        int age;
        string sex;

        public Person()
        {
            id = 1;
            fname = "Marcin";
            lname = "Kowalski";
            age = 14;
        }

        public Person(int id, string fname, string lname, string adress, int age, string sex)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.adress = adress;
            this.age = age;
            this.sex = sex;
        }

        public Person(int id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            adress = "Wroclaw";
            age = 18;
        }

        public Person(int id, string fname)
        {
            this.id = id;
            this.fname = fname;
        }
    }
}
