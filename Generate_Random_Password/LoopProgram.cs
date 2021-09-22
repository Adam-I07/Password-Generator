using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Random_Password
{
    class LoopProgram
    {
        EightLetterPass eightLetter = new EightLetterPass();
        TwelveLetterPass twelveLetter = new TwelveLetterPass();
        EightSpecialLetterPass eightSpecialLetter = new EightSpecialLetterPass();
        FourNumPass fourNum = new FourNumPass();
        SixNumPass sixNum = new SixNumPass();
        TwelveSpecialLetterPass twelveSpecialLetter = new TwelveSpecialLetterPass();

        public void RunProgram()
        {
            int runAgain = 1;
            string again;

            while (runAgain == 1)
            {
                Console.WriteLine("Would you like to generate another password y (yes) or n (no): ");
                again = Convert.ToString(Console.ReadLine()).ToLower();
                if (again == "y")
                {
                    int choice;
                    Console.WriteLine("Password options:");
                    Console.WriteLine("(1) 8 Letter Character Password.");
                    Console.WriteLine("(2) 12 Letter Character Password.");
                    Console.WriteLine("(3) 8 Letter Special Character Password.");
                    Console.WriteLine("(4) 12 Letter Special Character Password.");
                    Console.WriteLine("Phone Digit Passwords:");
                    Console.WriteLine("(5) 4 Digit Password");
                    Console.WriteLine("(6) 6 Digit Password");
                    Console.WriteLine("What Password would you like to generate: ");
                    var userChoice = Console.ReadLine();
                    bool continueChoice = false;

                    do
                    {
                        int.TryParse(userChoice, out choice);

                        if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5 || choice == 6)
                        {
                            continueChoice = true;
                            switch (choice)
                            {
                                case 1:
                                    eightLetter.GenPass();
                                    break;
                                case 2:
                                    twelveLetter.GenPass();
                                    break;
                                case 3:
                                    eightSpecialLetter.GenPass();
                                    break;
                                case 4:
                                    twelveSpecialLetter.GenPass();
                                    break;
                                case 5:
                                    fourNum.GenPass();
                                    break;
                                case 6:
                                    sixNum.GenPass();
                                    break;

                            }

                        }
                        else
                        {
                            Console.WriteLine("That is not one of the numbers from the menu! Try again: ");
                            userChoice = Console.ReadLine();
                        }
                    } while (continueChoice == false);
                }
                if(again == "n")
                {
                    break;
                }
            }
            System.Environment.Exit(0);
        }
        
    }
}
