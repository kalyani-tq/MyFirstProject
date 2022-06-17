using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Student
    {
        public int id;
        public string name;
        public int m1,m2,m3;
        int per;

        public void AcceptDetails(int sid,string sname,int sub1,int sub2,int sub3)
        {
            id = sid;
            name = sname;
            m1 = sub1;
            m2 = sub2;
            m3 = sub3;
        }
        public void calculate()
        {
            per = (m1 + m2 + m3) / 3;
        }  
        void Display()
        {
            Console.WriteLine("id \t Name\t m1 \t m2 \t m3 \t per");  
            Console.WriteLine(id+"   "+name+"      "+m1+"      "+m2+"       "+m3+"       "+per);
        }


       
        static void Main(string[] args)
        {
            
            Student nikhil;
            nikhil = new Student();

            nikhil.AcceptDetails(1, "Amit", 67, 78, 89);
            nikhil.calculate();
            nikhil.Display();

           /* nikhil.id = 45;
            nikhil.name = "NIKHIL";
            nikhil.marks = 78;*/
/*
            Student stud = new Student();
            stud.id = 100;
            stud.name = "Yash";
            stud.marks = 66;*/

         //   Console.WriteLine(nikhil.id+" "+nikhil.name+" "+nikhil.marks);

           // Console.WriteLine(stud.id+" "+stud.name+" "+stud.marks);

        }


    }

    class StudInfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 666;
            s.name = "Sonia";
          //  s.marks = 77;
           // Console.WriteLine(s.id + " " + s.name + " " + s.marks);
        }
    }



}
