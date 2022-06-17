using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Car
    {
       private int modelno;
        private string name;
       private  string color;
       private int price;

        public int Modelno { get => modelno; set => modelno = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }





        /*    public int Modelno
            {
                get { return modelno; }
                set { modelno = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Color
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }*/


    }


    class CarInfo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Modelno = 2344;
            c.Name = "Audi";
            c.Color = "Black";
            c.Price = 789999000;
            int number = c.Modelno;
            Console.WriteLine(number);

            Console.WriteLine(c.Name+" "+c.Price+" "+c.Color);

        }
    }

}
