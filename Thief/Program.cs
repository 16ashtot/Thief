using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to pin generator");

            int d1 = 0;
                Console.WriteLine("1st digit");
            d1 = int.Parse(Console.ReadLine());

            int d2 = 0;
            Console.WriteLine("2nd digit");
            d2 = int.Parse(Console.ReadLine());

            int d3 = 0;
            Console.WriteLine("3rd digit");
            d3 = int.Parse(Console.ReadLine());

            int d4 = 0;
            Console.WriteLine("4th digit");
            d4 = int.Parse(Console.ReadLine());

            Console.WriteLine("list: " +d1+d2+d3+d4 + ", " +d1+d2+d4+d3+ ", " +d1+d3+d2+d4+ ", " +d1+d3+d4+d2+ ", " +d1+d4+d3+d2+ ", " +d1+d4+d2+d3+ 
                ", " +d2+d1+d3+d4+ ", " +d2+d1+d4+d3+ ", " +d2+d3+d1+d4+ ", " +d2+d3+d4+d1+ ", " +d2+d4+d3+d1+ ", " +d2+d4+d1+d3+ 
                ", " +d3+d1+d2+d4+ ", " +d3+d1+d4+d2+ ", " +d3+d2+d1+d4+ ", " +d3+d2+d4+d1+ ", " +d3+d4+d1+d2+ ", " +d3+d4+d2+d1+ 
                ", " +d4+d3+d2+d1+ ", " +d4+d3+d1+d2+ ", " +d4+d2+d3+d1+ ", " +d4+d2+d1+d3+ ", " +d4+d1+d2+d3+ ", " +d4+d1+d3+d2);
            Console.ReadLine();

        }
    }
}
