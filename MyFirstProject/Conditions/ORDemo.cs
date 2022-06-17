using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class ORDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }


        }
       
    }
}
