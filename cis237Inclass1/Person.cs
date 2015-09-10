using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Person
    {

        //class variables
        string firstName;
        string lastName;
        int age;
        
        //default constructor
        public Person()
        {

        }

        //3 parameter constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public void PrintFullName()
        {
            Console.WriteLine(this.firstName + ' ' + this.lastName);            
        }

        //first name property
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }
    }
}
