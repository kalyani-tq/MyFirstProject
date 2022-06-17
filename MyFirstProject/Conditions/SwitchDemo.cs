using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditions
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            //switch(expression)
            //{
            //case:
            //break;
            //case:
            //break;
            //default:
            //break;



            //}


            /* Console.WriteLine("enter the number between 1 to 5");

             int num = int.Parse(Console.ReadLine());

             switch(num)
             {
                 default:
                     Console.WriteLine("Invalid number");
                     break;
                 case 1: Console.WriteLine("One");
                     break;

                 case 3: Console.WriteLine("Three");
                     break;
                 case 4: Console.WriteLine("Four");
                     break;
                 case 2:
                     Console.WriteLine("Two");
                     break;
                 case 5: Console.WriteLine("Five");
                     break;

             }*/
            Console.WriteLine("Enter char");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a': 
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonent");
                    break;

            }

            /*    Console.WriteLine("Enter the input");
                string input = Console.ReadLine();


                switch(input)
                {
                    case "happy": Console.WriteLine("Happy");
                        break;
                    case "new": Console.WriteLine("New");
                        break;
                    case "year": Console.WriteLine("Year");
                        break;
                    default: Console.WriteLine("Welcome");
                       break;*/
        //}

        }
    }
}
