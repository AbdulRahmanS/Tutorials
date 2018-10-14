using System;
using System.Collections.Generic;

using System.Text;


namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Input String
            string input = "Data Input test";

            Console.WriteLine(input);

            Console.WriteLine(MoveTheSpacetoFront(input));

            Console.ReadKey();
        }

        /// <summary>
        /// Move the space in the string to the front of the string
        /// </summary>
        /// <param name="input"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        static string MoveTheSpacetoFront(string input, int option = 1)
        {
            string output = string.Empty;

            switch (option)
            {
                case 1:
                    // Using Substring
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input.Substring(i, 1) == " ")
                        {
                            output = input.Substring(i, 1) + output;
                        }
                        else
                        {
                            output += input.Substring(i, 1);
                        }
                    }
                    break;
                case 2:
                    char[] charArray = input.ToCharArray();

                    // Using Char array
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (charArray[i] == ' ')
                        {
                            output = charArray[i] + output;
                        }
                        else
                        {
                            output += charArray[i];
                        }
                    }
                    break;
                default:
                    break;
            }
            return output;

        }

    }
}
