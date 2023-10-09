using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static is the about class itself, no need to create objectsto get to the class itself.

            Console.WriteLine(Math.Sqrt(64));
            //UseFulL tools = new UseFullTools(); if u maje the class static as well, u will only access it with direct methods,
            //no more objects, just like u cant make an object of the Math class
            UseFullTools.sayHi("Dineo"); 
            //

            //freeze
            Console.ReadLine();

        }
        static internal class UseFullTools
            //this make this class only accesible through methods not through objects
        {
            public static void sayHi(String name)
            {

                Console.WriteLine("Hi" + name);
             }
        }
    }
}
