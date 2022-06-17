using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basic
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            byte mybyte = 12;//1 bytes ,8 bits// 127 to -128
            sbyte mybyte2 = -5;//7 bits value 1 bit for sign

            Console.WriteLine(mybyte +" "+mybyte2);

            ushort myshort = 457;//2 bytes  //32676 to -32676
            short myshort2 = -799;

            Console.WriteLine(myshort+" "+myshort2);

            int m1 = 67788;//4 bytes //2^31 to 2^-31
            int m2 = -89769;

           ulong l = 9865744232342289979L;//8bytes  //2^64 to 2^-64

            Console.WriteLine(l);

            double per = 67.78;//8 bytes
            Console.WriteLine(per);

            float ft = 89.67F;// 4 bytes
            Console.WriteLine(ft);

            char ch = 'p';
            Console.WriteLine(ch);

            bool isbool = true;
            Console.WriteLine(isbool);

            string name = "nikita";
            Console.WriteLine(name);










        }
    }
}
