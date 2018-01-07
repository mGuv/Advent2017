using System;
using System.Collections.Generic;

namespace Advent2017.Executions
{
    /// <summary>
    /// Base class for calculating the inverse captcha so that it can be used with many different offsets.
    /// </summary>
    abstract class AbstractInverseCaptcha : IExecution
    {   
        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public abstract string Name
        {
            get;
        }

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public abstract string Description
        {
            get;
        }

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// Returns the mathematical modulus of a number divided by a range. Different to using % as % doesn't work with negatives how one would expect. % does not loop round when using negatives, whilst this does.
        /// </summary>
        /// <param name="x">The number to find the remainder of</param>
        /// <param name="m">The number to divide by</param>
        /// <returns></returns>
        private int Modulus(int x, int m)
        {
            return (x % m + m) % m;
        }

        /// <summary>
        /// Calculates the total of a series of digits, when two digits separated by the offset match.
        /// </summary>
        /// <param name="digits">All the digits to compare between</param>
        /// <param name="offset">The offset from a given digit to compare to</param>
        protected void Calculate(int[] digits, int offset)
        {
            int total = 0;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int neighbourIndex = Modulus(i + offset, digits.Length);
                if (digits[i] == digits[neighbourIndex])
                {
                    total += digits[i];
                }
            }

            Console.WriteLine("Total: " + total);
        }

        /// <summary>
        /// Requests and gets the input of numbers to use for calculating the captcha from the user.
        /// </summary>
        /// <returns>An array of numbers to calculate the captcha against</returns>
        protected int[] GetInput()
        {
            Console.WriteLine("Please enter the series of digits to calculate the captcha from: ");
            while (true)
            {
                string input = Console.ReadLine();
                List<int> digits = new List<int>();
                foreach(char character in input)
                {
                    int value;

                    if(!int.TryParse(character.ToString(), out value))
                    {
                        Console.WriteLine("WARNING - Skipped invalid character: " + character);
                        continue;
                    }

                    digits.Add(value);
                }

                if (digits.Count <= 1)
                {
                    Console.WriteLine("There must be at least 2 digits.");
                    continue;
                }

                return digits.ToArray();
            }
        }
    }
}
