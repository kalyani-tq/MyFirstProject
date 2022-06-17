using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class ArrayCreation
    {
        static void Main(string[] args)
        {
            /*int x;
             * x=23;
             * int x = 1;
             int y = 2;
             int z = 56;
             int p = 78;*/
            int[] arr = {7,8,1,4,2,0 };

            int[] a = new int[5];//declaretion

            //1.
            /* a[0] = 44;
             a[1] = 12;
             a[2] = 78;
             a[3] = 4;
             a[4] = 7;*/
            Console.WriteLine("enter Array Elemennts");
            for(int i=0;i<a.Length;i++)
            {
                /*int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;*/
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("///////////////////////////");

            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("//////////////////////");

            foreach(int x in a)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("///////////////////////");

            Console.WriteLine(string.Join(" ",a));
            Console.WriteLine("//////////////////////////");





        }


    }
}
