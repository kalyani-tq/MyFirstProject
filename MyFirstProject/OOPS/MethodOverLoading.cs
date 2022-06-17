using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class MethodOverLoading
    {

        void show()
        {
            Console.WriteLine("show");
        }
        void show(string str)
        {
            Console.WriteLine("str="+str);

        }
      int show(int x)
        {
            Console.WriteLine("x  "+x);
            return 0;
        }

        
        void show(int x,int y)
        {
            Console.WriteLine("Add="+(x+y));
        }


        static void Main(string[] args)
        {
            MethodOverLoading m = new MethodOverLoading();
            m.show(10);
            m.show();
            m.show("Pune");
            m.show(4, 5);
        }
    }
}
