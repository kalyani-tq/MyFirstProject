using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class ArrayMerge
    {

        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44 };
            int[] b = { 101, 102, 103, 104 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j++;
            }
            for(int i=0;i<b.Length;i++)
            {
                c[j] = b[i];
                j++;
            }

            Console.WriteLine("////////////////////");
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.WriteLine(".....................");

            foreach(int x in c)
            {
                Console.WriteLine(x);
            }


        }
    }
}
