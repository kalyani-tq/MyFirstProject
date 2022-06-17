
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class MethodDemo
    {
        //accessmodifier  returntype methodname(parameterlist)
        //{
                //logic
            
        //}
        //1. no return type no paramter

        public void show()
        {
            Console.WriteLine("Show method");//method defination/body
        }
        //2.no return type with paramter

        public void Addition(int x,int y,double z)
        {
            Console.WriteLine("Addition=  "+(x+y+z));
        }


        //3.with return type no parameter

        public double  Area()
        {
            double area = 3.14 * 4 * 4;
            return area;

        }
        //4.with retuen type with parameter

        public float calculate(int x,float y)
        {
            float ans = x * y;
            return ans;
        }



        static void Main(string[] args)
        {

            MethodDemo d = new MethodDemo();
            d.show();//method calling

            d.Addition(4,3,4.3);


            double ans=d.Area();

            Console.WriteLine("Area of cirle is= "+ans);
            Console.WriteLine("Area of cirle is= " + d.Area());


            float result = d.calculate(5, 4.3f);
            Console.WriteLine(result);

            Console.WriteLine(d.calculate(5,3.3f));

        }
    }
}
