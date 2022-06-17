using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Person
    {
       public string name="Rajesh";
    }
    class Employee:Person
    {
       public  int id=101;
       public string deptname="sales";
    }
    class Manager:Employee
    {
        public int salary=900000;

        public void show()
        {
            Console.WriteLine(name+" "+id+" "+deptname+" "+salary);
        }

    }



    class MultiLevelDemo
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.show();
        }
    }
}
