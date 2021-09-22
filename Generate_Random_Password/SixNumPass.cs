using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Password
{
    class SixNumPass
    {
        Random GetRandom = new Random();
        string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void GenPass()
        {
            int randNum1 = GetRandom.Next(numbers.Length);
            int randNum2 = GetRandom.Next(numbers.Length);
            int randNum3 = GetRandom.Next(numbers.Length);
            int randNum4 = GetRandom.Next(numbers.Length);
            int randNum5 = GetRandom.Next(numbers.Length);
            int randNum6 = GetRandom.Next(numbers.Length);
            Console.WriteLine(numbers[randNum1] + numbers[randNum2] + numbers[randNum3] + numbers[randNum4] + numbers[randNum5] + numbers[randNum6]);
        }
    }
}
