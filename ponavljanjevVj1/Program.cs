using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanjevVj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b; 
            int c;

            Console.WriteLine("Upiši 3 dvoznamenkasta broj: ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if(a > b && a > c)
            {
                Console.WriteLine(a + " je največi broj.");
            }

            if(b > c && b > a)
            {
                Console.WriteLine(b + " je najveći broj");
            }

            if (c > a && c > b)
            {
                Console.WriteLine(c + " je najveći broj");
            }

            Console.ReadKey();
        }
    }
}
