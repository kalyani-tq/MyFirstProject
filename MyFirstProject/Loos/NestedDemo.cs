using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Loos
{
    class NestedDemo
    {
        static void Main(string[] args)
        {
            /*   for(int i=1;i<=3;i++)
               {
                   for(int j=1;j<=2;j++)
                   {
                       Console.WriteLine(j);
                   }
               }*/

            /*    for(int i=1;i<=3;i++)
                {
                    for(int j=1;j<=3;j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();

                }*/

            /*   for (int i = 1; i <= 4; i++)
               {
                   for (int j = 1; j <= i; j++)
                   {
                       Console.Write("*");
                   }
                   Console.WriteLine();

               }*/


        /*    for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >=i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }*/

           /* for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    if(i==1||i==4||j==1||j==4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/
           

            /*for(int i=1;i<=4;i++)
            {

                for(int k=4;k>=i;k--)
                {
                    Console.Write(" ");
                }


                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
          


            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=4;j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////////////");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////////////////////////////");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine("//////////////////////////");

            for(char ch='A';ch<='D';ch++)
            {
                for(char ch2='A';ch2<='D'; ch2++)
                {
                    Console.Write(ch+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("//////////////////////");

            for (char ch = 'A'; ch <= 'D'; ch++)
            {
                for (char ch2 = 'A'; ch2 <= 'D'; ch2++)
                {
                    Console.Write(ch2 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////");

            for (char ch = 'A'; ch <= 'D'; ch++)
            {
                for (char ch2 = 'A'; ch2 <= ch; ch2++)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("/////////////////////////");

            /*    int c = 64;


                for(int i=1;i<=4;i++)
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write((char)(c+i) );
                    }
                    Console.WriteLine();
                }*/
            int c = 64;


            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(c + j));
                }
                Console.WriteLine();
            }

        }
    }
}
