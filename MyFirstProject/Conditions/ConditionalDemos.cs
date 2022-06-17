using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class ConditionalDemos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());


            if(num1>num2)
            {
                Console.WriteLine("num1 is gr="+num1);
            }
            else
            {
                Console.WriteLine("num2 is gr= "+num2);
            }

        }
    }


    class Conditiondemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter char ");
            char ch = Console.ReadLine()[0];

            if(ch>='a')
            {
                if(ch<='z')
                {
                    Console.WriteLine("Alphabet");
                }
            }
            else if(ch>='A' && ch<='Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Symbol");
            }

        }
    }

}
