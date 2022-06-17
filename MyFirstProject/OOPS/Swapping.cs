using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Swapping
    {


        public void swap(ref int x,ref int y)

        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {


            Swapping s = new Swapping();
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");

            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+" "+num2);
            s.swap(ref num1,ref num2);
            Console.WriteLine(".................................");

            Console.WriteLine(num1+" "+num2);

        }
    }
}
