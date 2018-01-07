namespace Advent2017.Executions.InverseCaptcha
{
    /// <summary>
    /// Calculates the inverse captcha using the neighbour half way round the input as a looped list.
    /// </summary>
    class HalfLengthNeighbour : AbstractInverseCaptcha
    {
        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override string Name => "Inverse Captcha - Neighbour Half Way Round";

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override string Description => "Finds all digits that match to the neighbour half way round the input from their position, calculates the total for all digits that matched.";

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override void Run()
        {
            // Calculate using the neighbour to the left
            int[] input = this.GetInput();
            this.Calculate(input, input.Length / 2);
        }
    }
}
