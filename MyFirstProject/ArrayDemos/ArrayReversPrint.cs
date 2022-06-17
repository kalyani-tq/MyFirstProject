using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class ArrayReversPrint
    {
        static void Main(string[] args)
        {

            int[] a = { 5, 7, 2, 3 ,6,1};
            //display even elements from array
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
            }

            //display array in revers order
            /*   Console.WriteLine(string.Join(" ",a));
               Console.WriteLine();
               for(int i=a.Length-1;i>=0;i--)
               {
                   Console.Write(a[i]+" ");
               }*/
        }
    }
}
