using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{

    class Laptop
    {
        public  string memory = "500GB";
    }
    class DELL:Laptop
    {
        public string RAM = "16GB";
    }
    class HP:Laptop
    {
        public string screen = "32inch";
    }
    class Accer:Laptop
    {
        public string camera = "3.5px";
    }

    class HierarchicalDemo
    {
        static void Main(string[] args)
        {

            DELL d = new DELL();
            Console.WriteLine("DELL    "+d.memory+" "+d.RAM);
            HP p = new HP();
            Console.WriteLine(" HP   "+p.memory+" "+p.screen);
            Accer a = new Accer();
            Console.WriteLine("Accer    "+a.memory+" "+a.camera);

        }
    }
}
