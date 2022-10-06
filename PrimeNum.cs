using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNumbers
    {
        public static void primeNumbers()
        {
            bool prime = true;

            Console.WriteLine("INPUT ANY NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    Console.WriteLine("{0} NUMBER IS NOT A PRIME NUMBER ", num);
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("{0} NUMBER IS A PRIME NUMBER ", num);
                Console.ReadLine();
            }
        }
    }

}