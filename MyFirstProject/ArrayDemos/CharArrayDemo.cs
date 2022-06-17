using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.ArrayDemos
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 't', 'Y', 'r' };

            char[] ch1 = new char[4];
            for(int i=0;i<ch1.Length;i++)
            {
                ch1[i] = Convert.ToChar(Console.ReadLine());
            }

            string[] st = { "pune", "Mumbai", "Goa" };

        }
    }
}
