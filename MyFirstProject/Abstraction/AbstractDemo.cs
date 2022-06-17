using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    abstract class Vehical
    {

        public int x=10;
        public static int y = 78;

        //Abstract Method
        public abstract void run();
        //constructor 
        public Vehical(string name)
        {
            Console.WriteLine("CarName=  "+name);
        }
        //method
        public void show()
        {
            Console.WriteLine("show Method");
        }

    }

    class Car:Vehical
    {
        int x=34;
        //constructor Calling
        public Car():base("Audi")
        {
            Console.WriteLine("MyCar");
        }

        //Method Overriding
        public override void run()
        {
            
            Console.WriteLine(  "Car is running...."+x+"  "+y+" "+base.x);
        }

    }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Vehical v = new Car();
            v.run();
            v.show();

        }
       
        

    }
}
