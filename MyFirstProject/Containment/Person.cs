using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Address
    {
       public  int pincode;
        public String city;
        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
        public void show()
        {
            Console.WriteLine(pincode+"  "+city);
        }
    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id,string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;
        }

        void display()
        {
            Console.Write(id+" "+name+" ");
            adr.show();
        }

        static void Main(string[] args)
        {
            /*Address a = new Address(2343, "Pune");

        
            Person p = new Person(1, "amit", a);*/

            Person p = new Person(1, "Amit", new Address(234, "Pune"));//anonymous object creation
            // Console.WriteLine(p);
            p.display();


        }
    }
}
