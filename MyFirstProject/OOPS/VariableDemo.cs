using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class VariableDemo
    {
       public  int x;

        public void Accept()
        {
            x = 101;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            VariableDemo v = new VariableDemo();
            v.Accept();
            v.Display();
        }
    }

    class Method2
    {
        public int x;
        public void ReadValue(int id)
        {
            x = id;
        }
        public void Show()
        {
            Console.WriteLine(x);
        }

        public void check(int num)
        {

            int temp = num;

            int sq = num * num;
            int count = 0;
            while(num>0)
            {
                count++;
                num = num / 10;
            }

            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }

            int division = sq / power;
            int reminder = sq % power;

            int sum = division + reminder;
            if(sum==temp)
            {
                Console.WriteLine("Kaprekar");
            }
            else
            {
                Console.WriteLine("Not");
            }

        }




        static void Main(string[] args)
        {
            Method2 m = new Method2();
            /* m.ReadValue(123);
             m.Show();*/
            m.check(2728);
        }
    }


}
