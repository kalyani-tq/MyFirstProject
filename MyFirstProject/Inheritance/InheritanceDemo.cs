using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{

    class Animal
    {
        public int legs = 0;

        public void display()
        {
            Console.WriteLine("Animal");
        }

    }

    class Dog:Animal
    {


       public void show()
        {
            legs = 4;
            Console.WriteLine(legs);
        }
    }

    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            d.display();
        }
    }
}
