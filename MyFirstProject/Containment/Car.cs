using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{

    class SubEngine
    {
        string cleanupDate;
        public SubEngine(string cleanupDate)
        {
            this.cleanupDate = cleanupDate;
        }

        public void show()
        {
            Console.WriteLine(cleanupDate);
        }

    }
    class Engine
    {
        string type;
            SubEngine sub;
        public Engine(string type,SubEngine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void ShowEngine()
        {
            Console.WriteLine(type);
            sub.show();
        }

    }

    class Car
    {

        int model;
        string name;
        int price;
        Engine e;
        Car(int model,string name,int price,Engine e)
        {
            this.model = model;
            this.name = name;
            this.price = price;
            this.e = e;
        }
        public void showCar()
        {
            Console.WriteLine(model+" "+name+" "+price);
            e.ShowEngine();
        }

        static void Main(string[] args)
        {
            Car c = new Car(123, "Audi", 7800099, new Engine("Petrol", new SubEngine("5/5/2022")));
            c.showCar();
            
        }


    }
}
