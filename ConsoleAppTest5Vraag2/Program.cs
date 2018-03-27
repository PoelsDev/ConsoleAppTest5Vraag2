using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest5Vraag2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 1;
            Console.WriteLine("a = {0} en b = {1}.", a,b);

            SomEnVerschil(ref a, ref b);
            Console.WriteLine("De som van a en b is {0}, het verschil tussen a en b is {1}.", a, b);
            
        }

        static void SomEnVerschil(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = a + b;
            b = aCopy - b;
        }
    }
}
