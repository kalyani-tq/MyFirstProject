using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class UserInput
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine(1);

            /*  Console.WriteLine("enter the city");
              string input = Console.ReadLine();
              Console.WriteLine(input+2);*/

            // Console.WriteLine("enter the number");

            /*int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);*/
            /*   double d = double.Parse(Console.ReadLine());
               Console.WriteLine(d);

               *//*  int num =Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(num+2);*//*

               double f = Convert.ToDouble(Console.Read());

               Console.WriteLine(f);

               float f2 = float.Parse(Console.ReadLine());
               Console.WriteLine(f2);


               bool b = bool.Parse(Console.ReadLine());
               Console.WriteLine(b);
               bool b2 = Convert.ToBoolean(Console.ReadLine());
               Console.WriteLine(b2);
   */


            Console.WriteLine("enter the char");

            char ch = Console.ReadLine()[0];
            Console.WriteLine(ch);

            char ch1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch1);


        }
    }
}
