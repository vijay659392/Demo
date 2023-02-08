using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        int countHead = 0;
        int countTail = 0;
        public void coin()
        {
            Console.WriteLine("Enter the number of times to flip the coin");
            int flipnum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for(int i = 0;i < flipnum;i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("Count of Head : " + countHead);
            Console.WriteLine("Count of Tail : " + countTail);

            double headPercentage = (double)countHead / countTail * 100;
            double tailPercentage = (double)countTail / countHead * 100;

            Console.WriteLine("Percentage of head : " + headPercentage);
            Console.WriteLine("Percentage of tail : " + tailPercentage);
        }
    }
}
