using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{


    class Mobile
    {
        string memory = "64GB";
        public Mobile()
        {
            Console.WriteLine("Mobile Memory= "+memory+" ");
        }
    }
    class Apple:Mobile
    {
       public  Apple(int y):base()
        {
            Console.WriteLine("Apple");
        }
    }

    class BaseConstructorDemo
    {
        static void Main(string[] args)
        {
            Apple a = new Apple(890);
            
        }
        

    }
}
