using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Abstraction
{
    public interface IPrintable
    {
        void run();
    }
   public  interface IMoveable
    {
        public static int x = 67;
        void show();

        static void move()
        {
            Console.WriteLine("Move");
        }
        internal void foo()
        {
            Console.WriteLine(":foo");
        }
    }
    class InterfaceDemo:IMoveable,IPrintable
    {

        public void show()
        {
            Console.WriteLine("Show Method"+" "+IMoveable.x);
        }
        public void run()
        {
            Console.WriteLine("run.....");
        }
        static void Main(string[] args)
        {
            IMoveable m = new InterfaceDemo();
            m.show();
            IMoveable.move();
            m.foo();
            IPrintable p = new InterfaceDemo();
            p.run();
        }
    }
}
