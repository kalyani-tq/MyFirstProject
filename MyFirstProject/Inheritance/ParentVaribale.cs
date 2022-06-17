using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Student
    {
       public int marks = 78;

        public void get(string name)
        {
            Console.WriteLine("Student"+name);
        }
    }

    class Teacher:Student
    {
       public int marks = 90;
       public  void show()
        {
            Console.WriteLine(marks+" "+base.marks);
        }
        public void get()
        {
            base.get("Sneha");

            Console.WriteLine("Teacher");
        }
    }


    class ParentVaribale
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.show();
            t.get();
        }
       
        
    }
}
