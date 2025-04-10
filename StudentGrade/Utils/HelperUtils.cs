using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade.Utils
{
    public static class HelperUtils
    {
        public static string StringWriter(string message)
        {
            do
            {
                try
                {
                    Console.WriteLine("Please enter the " + message);
                    string? userInput = Console.ReadLine();

                    if (userInput != null)
                    {
                        if (userInput.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }

                        if (IsValidString(userInput))
                        {
                            return userInput;
                        }
                        else
                        {
                            Console.WriteLine("Please enter only characters");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid character: Avoid entering numbers");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("This is the exception caught: " + e.Message);
                }

            } while (true);
        }

        public static int IntegerWriter(string message)
        {
            do
            {
                try
                {
                    Console.WriteLine("Please enter the " + message);
                    string? userInput = Console.ReadLine();
                    if (userInput != null)
                    {
                        if (userInput.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }

                        if (IsValidNumber(userInput))
                        {
                            return int.Parse(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Please enter only numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number: Avoid entering characters");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("This is the exception caught: " + e.Message);
                }

            } while (true);
        }

        public static float FloatWriter(string message)
        {
            do
            {
                try
                {
                    Console.WriteLine("Please enter the " + message);
                    string? userInput = Console.ReadLine();
                    if (userInput != null)
                    {
                        if (userInput.ToLower() == "exit")
                        {
                            Environment.Exit(0);
                        }

                        if (IsValidNumber(userInput))
                        {
                            return float.Parse(userInput);
                        }
                        else
                        {
                            Console.WriteLine("Please enter only numbers");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number: Avoid entering characters");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("This is the exception caught: " + e.Message);
                }

            } while (true);
        }

        private static bool IsValidString(string text)
        {
            return text.All(char.IsLetterOrDigit);
        }

        private static bool IsValidNumber(string number)
        {
            return number.All(char.IsDigit);
        }
    }
}
