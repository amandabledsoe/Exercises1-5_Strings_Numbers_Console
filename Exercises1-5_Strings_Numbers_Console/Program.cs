using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises1_5_Strings_Numbers_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            bool doingExercise1;
            bool doingExercise2;
            bool doingExercise3;
            bool doingExercise4;
            bool doingExercise5;
            string userInput;
            bool isANumber;
            double userDouble;
            List<double> numbers4 = new List<double>();
            List<double> numbers5 = new List<double>();

            Console.WriteLine("Hello!");
            Console.WriteLine("This is the program for the Grand Circus C# .Net boot camp exercises 1-5: Strings, Numbers, Console");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            Console.Clear();

            while (runningProgram)
            {
                //BEGIN EXERCISE 1:
                doingExercise1 = true;
                Console.WriteLine("Exercise 1:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Prompt the user to enter a string. After the user enters a string, output the same string back to the console.");
                Console.WriteLine("");
                while (doingExercise1)
                {
                    Console.Write("Hello User! Please enter any phrase and I will repeat it back to you: ");
                    Console.WriteLine("");
                    userInput = Console.ReadLine();
                    DoExercise1(userInput);
                    doingExercise1 = false;
                }

                Console.WriteLine("Press Enter to move on to Exercise 2.");
                Console.ReadLine();
                Console.Clear();


                //BEGIN EXERCISE 2:
                doingExercise2 = true;
                Console.WriteLine("Exercise 2:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.");
                Console.WriteLine("");
                while (doingExercise2)
                {
                    Console.Write("Hello User! Please enter a number and I will output your number +1: ");
                    userInput = Console.ReadLine();
                    if (DoExercise2(userInput))
                    {
                        Console.WriteLine("");
                        doingExercise2 = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        doingExercise2 = false;
                    }
                }
                Console.WriteLine("Press Enter to move on to Exercise 3.");
                Console.ReadLine();
                Console.Clear();


                //BEGIN EXERCISE 3:
                doingExercise3 = true;
                Console.WriteLine("Exercise 3:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.");
                Console.WriteLine("");
                while (doingExercise3)
                {
                    Console.Write("Hello User! Please enter a number and I will output your number +0.5: ");
                    userInput = Console.ReadLine();
                    if (DoExercise3(userInput))
                    {
                        Console.WriteLine("");
                        doingExercise3 = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        doingExercise3 = false;
                    }
                }
                Console.WriteLine("Press Enter to move on to Exercise 4.");
                Console.ReadLine();
                Console.Clear();


                //BEGIN EXERCISE 4:
                doingExercise4 = true;
                Console.WriteLine("Exercise 4:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.");
                Console.WriteLine("");
                while (doingExercise4)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        if (numbers4.Count()<1)
                        {
                            Console.Write("Enter your first number: ");
                            userInput = Console.ReadLine();
                            Console.WriteLine("");
                            isANumber = double.TryParse(userInput, out userDouble);
                            if (isANumber)
                            {
                                numbers4.Add(userDouble);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                                Console.WriteLine("Press enter and let's try again");
                                Console.ReadLine();
                                i = 0;
                                doingExercise4 = false;
                            }
                        }
                        else if (numbers4.Count()<=1)
                        {
                            Console.Write("Enter your second number: ");
                            userInput = Console.ReadLine();
                            Console.WriteLine("");
                            isANumber = double.TryParse(userInput, out userDouble);
                            if (isANumber)
                            {
                                numbers4.Add(userDouble);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                                Console.WriteLine("Press enter and let's try again");
                                Console.ReadLine();
                                if (numbers4.Count() == 1)
                                {
                                    i = 1;
                                    doingExercise4 = true;
                                }
                                else
                                {
                                    doingExercise4 = false;
                                }
                            }
                        }

                    }
                    if (numbers4.Count()<=1)
                    {

                    }
                    else if (numbers4.Count() == 2)
                    {
                        int total = numbers4.Sum(x => Convert.ToInt32(x));
                        Console.WriteLine($"The sum of your two numbers is: {total}");
                    }
                    doingExercise4 = false;
                }    
                Console.WriteLine("");

                Console.WriteLine("Press Enter to move on to Exercise 5.");
                Console.ReadLine();
                Console.Clear();


                //BEGIN EXERCISE 5:
                doingExercise5 = true;
                Console.WriteLine("Exercise 5:");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.");
                Console.WriteLine("");
                while (doingExercise5)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        if (numbers5.Count() < 1)
                        {
                            Console.Write("Enter your first number: ");
                            userInput = Console.ReadLine();
                            Console.WriteLine("");
                            isANumber = double.TryParse(userInput, out userDouble);
                            if (isANumber)
                            {
                                numbers5.Add(userDouble);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                                Console.WriteLine("Press enter and let's try again");
                                Console.ReadLine();
                                i = 0;
                                doingExercise5 = false;
                            }
                        }
                        else if (numbers5.Count() <= 1)
                        {
                            Console.Write("Enter your second number: ");
                            userInput = Console.ReadLine();
                            Console.WriteLine("");
                            isANumber = double.TryParse(userInput, out userDouble);
                            if (isANumber)
                            {
                                numbers5.Add(userDouble);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't use this entry.");
                                Console.WriteLine("Press enter and let's try again");
                                Console.ReadLine();
                                if (numbers5.Count() == 1)
                                {
                                    i = 1;
                                    doingExercise5 = true;
                                }
                                else
                                {
                                    doingExercise5 = false;
                                }
                            }
                        }

                    }
                    if (numbers5.Count() <= 1)
                    {

                    }
                    else if (numbers5.Count() == 2)
                    {
                        int theTotal = 1;
                        foreach (int i in numbers5)
                        {
                            theTotal = theTotal * i;
                        }
                        Console.WriteLine($"The product of your two numbers is: {theTotal}");
                    }
                    doingExercise5 = false;
                }
                Console.WriteLine("");

                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();

                runningProgram = false;
            }
            Console.WriteLine("This concludes the program for Grand Circus C# .Net boot camp exercises 1-5: Strings, Numbers, Console");
            Console.WriteLine("Goodbye!");
        }
        static void DoExercise1(string userInput)
        {
            Console.WriteLine("");
            Console.WriteLine("Your phrase was: ");
            Console.WriteLine(userInput);
            Console.WriteLine("");
        }

        static bool DoExercise2(string userInput)
        {
            bool isANumber = int.TryParse(userInput, out int userInteger);
            if (isANumber)
            {
                Console.WriteLine("");
                Console.Write($"Your number +1 is: {userInteger + 1}");
                Console.WriteLine("");
                return false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't add one.");
                Console.WriteLine("Press enter and let's try again");
                Console.ReadLine();
                return true;
            }
        }
        static bool DoExercise3(string userInput)
        {
            bool isANumber = double.TryParse(userInput, out double userDouble);
            if (isANumber)
            {
                Console.WriteLine("");
                Console.Write($"Your number +0.5 is: {userDouble + .5}");
                Console.WriteLine("");
                return false;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, that doesnt appear to be a number or anything we can work with, so I can't add one.");
                Console.WriteLine("Press enter and let's try again");
                Console.ReadLine();
                return true;
            }
        }
    }
}
