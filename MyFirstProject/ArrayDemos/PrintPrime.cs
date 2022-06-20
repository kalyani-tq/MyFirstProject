using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class PrintPrime
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter Array Element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("//////////////////////////");
            for(int i=0;i<a.Length;i++)
            {
                bool isPrime = true;
                int n = a[i];
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime==true)
                {
                    Console.WriteLine(a[i]);
                }
            }

        }
    }
}
