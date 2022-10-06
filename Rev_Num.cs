using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class ReverseNumbers
    {
        public static void reverseNumber()
        {
            Console.WriteLine("INPUT NUMBER TO REVERSE");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Rev = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Rev = (Rev * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("REVERSE NUMBER IS {0}", Rev);
            Console.ReadLine();
        }
    }
}