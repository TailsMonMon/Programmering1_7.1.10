using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._1._10 {
    class Program {
        static void Main(string[] args) {
            int a = 8%3;
            Console.WriteLine("a "+a);   // Output: 2

            int b = 9%6;
            Console.WriteLine("b "+b);   // Output: 3

            int c = 9%5;
            Console.WriteLine("c "+c);   // Output: 4

            int d = 10%5;
            Console.WriteLine("d "+d);   // Output: 0

            int e = 28&10;
            Console.WriteLine("e "+e);   // Output: 8

            Console.ReadLine();
        }
    }
}
