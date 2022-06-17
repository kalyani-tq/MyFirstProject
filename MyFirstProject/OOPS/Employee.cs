using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Employee
    {

        int id;
        string name;
        int salary;

        public Employee(int eid,string ename,int esalary)
        {//initilization of instance variable
            id = eid;
            name = ename;
            salary = esalary;
        }

        void Display()
        {
            Console.WriteLine(id+" "+name+" "+salary);
        }


        static void Main(string[] args)
        {
            Employee e = new Employee(101,"Amit",678000);
            e.Display();
            //Console.WriteLine();

        }
    }


    class ThisVariables
    {
        int x;

        public ThisVariables(int x)
        {
            this.x = x;
        }
        public void show()
        {
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            ThisVariables t = new ThisVariables(400);
            t.show();
        }
    }



    class ThisMethod
    {

        int x;
        public void get(int x)
        {
            this.x = x;
          //  this.show();


        }
        public void show()
        {
        get(45);
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ThisMethod t = new ThisMethod();
          //  t.get(89);
           t.show();
        }


    }

    class ThisConstructor
    {
        //constructor chaining
        public ThisConstructor():this(67)
        {
            Console.WriteLine("Default");
        }
        public ThisConstructor(int x)
        {
            Console.WriteLine("x= "+x);
        }
        public ThisConstructor(string city):this()
        {
            Console.WriteLine(city);
        }
        static void Main(string[] args)
        {
            ThisConstructor t = new ThisConstructor("pune");
        }
    }


}
