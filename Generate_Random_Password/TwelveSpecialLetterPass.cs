using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Password
{
    class TwelveSpecialLetterPass
    {
        Random randGen = new Random();
        string[] upperCaseAlphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] lowerCaseAlphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] specialCharacters = { "!", "£", "$", "%", "#", "&", "*", "?", "/", ",", ".", "'", ":", "@", ";" };
        string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void GenPass()
        {

            int indexLower1 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower2 = randGen.Next(lowerCaseAlphabet.Length);
            int indexLower3 = randGen.Next(lowerCaseAlphabet.Length);
            int indexNumber1 = randGen.Next(numbers.Length);
            int indexNumber2 = randGen.Next(numbers.Length);
            int indexNumber3 = randGen.Next(numbers.Length);
            int indexSpecial1 = randGen.Next(specialCharacters.Length);
            int indexSpecial2 = randGen.Next(specialCharacters.Length);
            int indexSpecial3 = randGen.Next(specialCharacters.Length);
            int indexUpper1 = randGen.Next(upperCaseAlphabet.Length);
            int indexUpper2 = randGen.Next(upperCaseAlphabet.Length);
            int indexUpper3 = randGen.Next(upperCaseAlphabet.Length);
            Console.WriteLine(upperCaseAlphabet[indexUpper1] + lowerCaseAlphabet[indexLower1] + specialCharacters[indexSpecial1] + numbers[indexNumber1] + upperCaseAlphabet[indexUpper2] + lowerCaseAlphabet[indexLower2] + specialCharacters[indexSpecial2] + numbers[indexNumber2] + lowerCaseAlphabet[indexLower3] + numbers[indexNumber3] + specialCharacters[indexSpecial3] + upperCaseAlphabet[indexUpper3]) ;

        }
    }
}
