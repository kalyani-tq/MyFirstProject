using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class MagicNumber
    {

        static void Main(string[] args)
        {
            int magicnumber = 67;

            for(; ; )
            {
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());


                if(num<magicnumber)
                {
                    Console.WriteLine("Number is less than magicNumber pls try again.....");
                    continue;
                }
                else if(num>magicnumber)
                {
                    Console.WriteLine("Number is greater pls try again......");
                    continue;
                }
                else
                {
                    Console.WriteLine("Congratulations   Number is match ........");
                    break;
                }
            }


        }
    }
}
