using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class ArraySearch
    {

        static void Main(string[] args)
        {
            int[] a = { 5, 7, 1, 9 };
            Console.WriteLine("enter element for search");
            int num = int.Parse(Console.ReadLine());
            bool isPresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    isPresent = true;
                    break;
                }
            }

            if(isPresent==true)
            { 

                    Console.WriteLine("Elements is present");
             }
             else
               {
                    Console.WriteLine("Not present");
                }
            
        }
    }
}
