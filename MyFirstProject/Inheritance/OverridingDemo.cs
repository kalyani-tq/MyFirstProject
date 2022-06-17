using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{


    class Vehical
    {
public  virtual void run()
        {
            Console.WriteLine("Vehical is running......");
        }
    }

    class Car:Vehical
    {
    public override void run()
        {
            Console.WriteLine("Car is running....");
           // return 3;
        }
    }
    class Truck:Vehical
    {
        public override void run()
        {
            Console.WriteLine("Truck is running..........");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            /*  Car c = new Car();
              c.run();*/
            Vehical v = new Car();
            v.run();
         v = new Truck();
            v.run();
        }
      
        

    }
}
