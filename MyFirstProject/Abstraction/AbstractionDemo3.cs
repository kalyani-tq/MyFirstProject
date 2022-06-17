using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{

   public  interface IDrawable
    {
        void draw();
    }
    abstract class Shape
    {
        public abstract void Fill(); 
    }

    class Circle:Shape,IDrawable
    {
        public void draw()
        {
            Console.WriteLine("Draw circle");
        }
        public override void Fill()
        {

            Console.WriteLine("Red color is fill in circle");

        }



    }


    class AbstractionDemo3
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.draw();
            c.Fill();

        }
       
        
    }
}
