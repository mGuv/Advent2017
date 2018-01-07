using System;
using System.Collections.Generic;
using System.IO;

namespace Advent2017
{
    /// <summary>
    /// Initial program script for when executable is ran.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Initial function/entry point when the application it executed.
        /// </summary>
        /// <param name="args">The arguments passed to the executable when it was executed.</param>
        static void Main(string[] args)
        {
            // Console.ReadLine has a max char of 254 by default - let us fix that to some super high random number
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192), Console.InputEncoding, false, 8192));

            Dictionary<string, IExecution> executionsByDay = new Dictionary<string, IExecution>();
            executionsByDay.Add("1a", new Executions.InverseCaptcha.LeftNeighbour());
            executionsByDay.Add("1b", new Executions.InverseCaptcha.HalfLengthNeighbour());



            while (true) {
                foreach (KeyValuePair<string, IExecution> executionByDay in executionsByDay)
                {
                    string key = executionByDay.Key;
                    IExecution execution = executionByDay.Value;
                    Console.WriteLine("[" + key + "] - " + execution.Name);
                }
                Console.WriteLine();
                Console.WriteLine("What day would you like to run? (q to quit)");
                string input = Console.ReadLine().ToLower();
                if (input == "q")
                {
                    return;
                }
                else if (executionsByDay.ContainsKey(input))
                {
                    IExecution execution = executionsByDay[input];
                    Console.WriteLine();
                    Console.WriteLine("--- " + execution.Name + " ---");
                    Console.WriteLine(execution.Description);
                    Console.WriteLine();
                    executionsByDay[input].Run();
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid key, try again.");
                }
             }
        }
    }
}
