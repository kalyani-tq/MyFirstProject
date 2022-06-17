using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class BreakContinueDemo
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("enter");

            /*  for(int i=1;i<=5;i++)
              {
                  if(i==3)
                  {
                      break;
                  }
                  Console.WriteLine(i);
              }*/

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3 || i==7 || i==9)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
