using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.coin();
                    break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;
            }
        }
    }
}
