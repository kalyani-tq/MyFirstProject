using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class ArrayWithMethod
    {

        public int SumOfEven(int []arr)
        {
            Console.WriteLine(arr.GetHashCode());
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            //Console.WriteLine("Sum of Even= "+sum);
            return sum;

        }
        public int[] ReverArray(int []revers)
        {
            int j = revers.Length - 1;
            for(int i=0;i<revers.Length/2;i++)
            {
                int temp = revers[i];
                revers[i] = revers[j];
                revers[j] = temp;
                j--;
            }
            return revers;

        }
        static void Main(string[] args)
        {
            int[] a = { 8, 3, 5, 1, 2 };
            ArrayWithMethod m = new ArrayWithMethod();
            /*  int sum= m.SumOfEven(a);
               Console.WriteLine(sum);*/
          int []b=  m.ReverArray(a);
            Console.WriteLine(string.Join(" ",b));
        }
    }
}
