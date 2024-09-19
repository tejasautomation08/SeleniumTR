using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept3
{
    internal class Program
    {
        public static int aS = 10; //static variable or class variable
        public static int bS = 20;

        public int aNS = 10; //non static variable or instance variable
        public int bNS = 20;

        static void Main(String[]args)
        {
            Program.aS = 1000;
            
            Console.WriteLine(Program.aS);
            Console.WriteLine(Program.bS);

            Program obj1= new Program();
            Program obj2 = new Program();

            obj1.aNS = 1000;

            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);
        }
    }
}
