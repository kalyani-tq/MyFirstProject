using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{


   abstract class Person
    {
        public abstract void show();
    }
   abstract class Employee:Person
    {

       /* public override void show()
        {
            Console.WriteLine("employee is working");

        }*/

    }
    class Manager:Employee
    {
        public override void show()
        {
            Console.WriteLine("Manager");
        }
    }
    class AbstractDemo2
    {
        static void Main(string[] args)
        {
            /* Person p = new Employee();
             p.show();*/
            Employee e = new Manager();
            e.show();
        }
        
       

    }
}
