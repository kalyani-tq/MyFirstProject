using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            /*  int i = 1;
              do
              {
                  Console.WriteLine(i);
                  i++;
              } while (i > 10);*/

            /*    int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i <= 10);
    */



          

            char ch;

            do
            {
                Console.WriteLine("enter 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Addition\n2.substraction\n3.Division\n4.Multiplication");
                Console.WriteLine("enter your Choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition= " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("substraction= " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Division= " + (num1 / num2));
                        break;
                    case 4:
                        Console.WriteLine("Multiplication= " + (num1 * num2));
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("Do you want to continue......");
                // ch = Console.ReadLine()[0];
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch=='y'||ch=='Y');

        }
    }
}
