using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] arrayTwo = { 999, -60, -77, 14, 160, 301 };
            int[] arrayThree = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
140, 150, 160, 170, 180, 190, 200, -99 };
            Console.WriteLine("{ 1, 90, -33, -55, 67, -16, 28, -55, 15 }");
            Console.WriteLine("{ 999, -60, -77, 14, 160, 301 }");
            Console.WriteLine("{ 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 }");

            Console.WriteLine("\nHere are the expected results:\n");

            Console.WriteLine($"#1 Array Sum: {Summer.ArrayAdder(arrayOne)}");
            Console.WriteLine($"#1 Array Sum: {Summer.ArrayAdder(arrayTwo)}");
            Console.WriteLine($"#1 Array Sum: {Summer.ArrayAdder(arrayThree)}");

            Console.ReadKey();
        }
    }
}
