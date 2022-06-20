using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            char[] c = { 't', 'o', 'G', 'Y', 'q' };
            char max = c[0];
            int x = 0;

            for(int i=0;i<c.Length;i++)
            {
                x = c[i];
                Console.WriteLine(c[i]+"  "+x);
                if(c[i]>max)
                {
                    max = c[i];
                    
                }
            }
            Console.WriteLine("//////////////////");
            Console.WriteLine("Max="+max);
        }
    }
}
