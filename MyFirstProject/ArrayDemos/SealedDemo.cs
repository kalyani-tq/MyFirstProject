using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{

  class Parent
    {

        public const int x=89;

        public Parent()
        {
         
        }
       public   virtual  void show()
        {
          
            Console.WriteLine("Parent");
        }
    }
    class Child:Parent
    {
        public   override void show()
        {
          
            Console.WriteLine("child show");

        }
    }
    class Subchild:Child
    {
        /*public override void show()
        {
            Console.WriteLine("subchild show");
        }*/
    }
    class SealedDemo
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.show();

            /*  Child c = new Subchild();
              c.show()*/
            ;

        }
    }
}
