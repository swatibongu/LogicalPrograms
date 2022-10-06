using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumbers
    {
        public static void perfectNumbers()
        {
            //variables
            int i, count;
            int a;

            Console.WriteLine("ENTER INITIAL NUMBER :");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER FINAL NUMBER :");
            int max = Convert.ToInt32(Console.ReadLine());

            //finding perfect number within given numbers
            //using for loop
            for (i = min; i <= max; i++)
            {
                a = 1;
                count = 0;
                while (a < i)
                {
                    if (i % a == 0)
                        count = count + a;
                    a++;
                }
                if (count == i)
                    Console.Write("{0} ", i);
            }
        }
    }
}