using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Test
    {
        static int x=10;

        public void get(int x)
        {
            //x = x;
           Test.x = x;
        }
        public void show()
        {
            Console.WriteLine(x);
        }




        static void Main(string[] args)
        {
            Test t = new Test();
            t.get(450);
            t.show();
        }
    }
}
