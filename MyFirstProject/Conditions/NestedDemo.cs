using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class NestedDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter the age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine( "enter the weight");
            int wt = int.Parse(Console.ReadLine());

            if(age>18 && wt>50)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }



           /* if(age>18)
            {
                if(wt>50)
                {
                    Console.WriteLine("Person is valid for blood donation");
                }
                else
                {
                    Console.WriteLine("Age is valid but not weight");
                }
            }
            else
            {
                Console.WriteLine("Not valid");
            }*/

        }
    }
}
