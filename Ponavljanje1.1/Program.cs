using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 3 dvoznamenkasta broja: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) { Console.WriteLine("Najveći broj je: " + a); }
            if (b > a && b > c) { Console.WriteLine("Najveći broj je: " + b); }
            if (c > b && c > a) { Console.WriteLine("Najveći broj je: " + c); }

            Console.ReadKey();
        }
    }
}
