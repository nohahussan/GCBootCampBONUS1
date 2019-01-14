using System;

namespace BONUS1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the letter Grade Converter!\n");

            string userChoice;

            do
            {

                Console.WriteLine("Enter a numerical grade : ");

                int grade;

                string letter;

                string userInput = Console.ReadLine();

                grade = int.Parse(userInput);

                if (grade > 100 || grade < 0)
                {
                    Console.WriteLine("Sorry you entered unvalid grade!!");
                }

                if (grade <= 100 && grade >= 88)
                {
                    letter += 'A';
                }
                else if (grade <= 87 && grade >= 80)
                {

                    letter += 'B';
                }

                else if (grade <= 79 && grade >= 67)
                {
                    letter += 'C';

                }

                else if (grade <= 66 && grade >= 60)
                {
                    letter += 'D';

                }
                else
                {
                    letter += 'F';
                }


                Console.WriteLine("Letter Grade : " + letter);

                Console.WriteLine("continue? (y/n)");

                userChoice = (Console.ReadLine()).ToLower();


                if (userChoice == "n")
                {
                    break;
                }

            } while (true);
        }
    }
}
