﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("John", "Harvey", 25);

            Person person2 = new Person("Joe", "Somebody", 85);





            person.PrintFullName();
            person2.PrintFullName();
            person.PrintFullName();

            PersonCollection personCollection = new PersonCollection();

            personCollection.addPerson(person);

            personCollection.addPerson(new Person("Not", "Declared First", 34));

            Console.WriteLine(personCollection.getPersonCollectionToString());
        }
    }
}
