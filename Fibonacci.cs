using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            //defination Variables
            int N1 = 0, N2 = 1, N3 = 0;
            int i = 0;
            int count = 10;
            Console.WriteLine("INPUT NUMBER :");
            Console.Write(N1 + " " + N2 + " ");
            for (i = 2; i < count; i++)
                N3 = N1 + N2;
            Console.WriteLine(N3 + " ");
            N1 = N2;
            N2 = N3;
        }
    }
}