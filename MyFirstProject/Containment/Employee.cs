using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Department
    {
        int did;
        string dname;
        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }
    }


    class Employee
    {
        int eid;
        string name;
        Department dept;


        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        static void Main(string[] args)
        {

            /*  Department d = new Department();
              d.Did = 1;
              d.Dname = "sales";

              Employee e = new Employee();
              e.Eid = 101;
              e.Name = "Amit";
              e.Dept = d;

              Console.WriteLine(e.Eid+" "+e.Name+" "+d.Did+" "+d.Dname);*/


            Employee e = new Employee();
            e.Eid = 101;
            e.Name = "Neha";
            e.Dept = new Department();

            e.Dept.Did = 1;
            e.Dept.Dname = "HR";


            Console.WriteLine(e.Eid+" "+e.Name+" "+e.Dept.Did+" "+e.Dept.Dname);


        }
    }
}
