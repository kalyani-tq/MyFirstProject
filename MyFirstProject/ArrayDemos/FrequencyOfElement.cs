using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class FrequencyOfElement
    {
        static void Main(string[] args)
        {

            //print duplicate elements from array
            int[] a = { 4, 1, 3, 1, 5, 1, 4 };
           
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(a[i]==a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }

            }
            
        }
    }
}
