using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class TarnaryDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());


            /*int result= num1 > num2 ? num1 : num2;
             Console.WriteLine(result);*/


           string ans= num1 > num2 ? "num1 is gr" : "num2 is gr";
            Console.WriteLine(ans);

        }
    }


    class TarnaryDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());


            /*   int temp = num1 > num2 ? num1 : num2;
               int max = num3 > temp ? num3 : temp;

               Console.WriteLine(max);*/


            int max = (num1 > num2) ? num1 > num3 ? num1 : num3 : num2 > num3 ? num2 : num3;

            Console.WriteLine(max);

            /*string str=num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";

            Console.WriteLine(str);*/


        }
    }
}
