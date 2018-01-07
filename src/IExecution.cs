using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2017
{
    /// <summary>
    /// Representation of an Advent challenge to run
    /// </summary>
    public interface IExecution
    {
        /// <summary>
        /// The display friendly name of the execution.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of what this execution does.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Run the execution, passing control/console to the execution.
        /// </summary>
        void Run();
    }
}
