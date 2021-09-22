using System;

namespace Generate_Random_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            EightLetterPass eightLetter = new EightLetterPass();
            TwelveLetterPass twelveLetter = new TwelveLetterPass();
            EightSpecialLetterPass eightSpecialLetter = new EightSpecialLetterPass();
            FourNumPass fourNum = new FourNumPass();
            SixNumPass sixNum = new SixNumPass();
            TwelveSpecialLetterPass twelveSpecialLetter = new TwelveSpecialLetterPass();
            LoopProgram loopProgram = new LoopProgram();

            Console.Title = "Password Generator";
            Console.ForegroundColor = ConsoleColor.Green;

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
            loopProgram.RunProgram();
        }
    }
}
