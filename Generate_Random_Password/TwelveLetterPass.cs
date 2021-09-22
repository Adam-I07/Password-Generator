using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Password
{
    class TwelveLetterPass
    {
        Random randGen = new Random();
        string[] upperCaseAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] lowerCaseAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };


        public void GenPass()
        {

            int indexLower1 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower2 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower3 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower4 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower5 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower6 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower7 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower8 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower9 = randGen.Next(lowerCaseAlphabet.Length);
            int indexUpper1 = randGen.Next(upperCaseAlphabet.Length);
            int indexUpper2 = randGen.Next(upperCaseAlphabet.Length);
            int indexUpper3 = randGen.Next(upperCaseAlphabet.Length);
            Console.WriteLine(upperCaseAlphabet[indexUpper1] + lowerCaseAlphabet[indexLower1] + lowerCaseAlphabet[indexLower2] + lowerCaseAlphabet[indexLower3] + lowerCaseAlphabet[indexLower4] + upperCaseAlphabet[indexUpper2] + lowerCaseAlphabet[indexLower5] + lowerCaseAlphabet[indexLower6] + lowerCaseAlphabet[indexLower7] + lowerCaseAlphabet[indexLower8] + lowerCaseAlphabet[indexLower9] + upperCaseAlphabet[indexUpper3]);
        }
    }
}
