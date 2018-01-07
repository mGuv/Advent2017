namespace Advent2017.Executions.InverseCaptcha
{
    /// <summary>
    /// Calculates the inverse captcha using the neighbour to the left in a looped list.
    /// </summary>
    class LeftNeighbour : AbstractInverseCaptcha
    {
        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override string Name => "Inverse Captcha - Neighbour to the Left";

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override string Description => "Finds all digits that match to the neighbour on their left and calculates the total for all digits that matched.";

        /// <summary>
        /// Inherit doc :(
        /// </summary>
        public override void Run()
        {
            // Calculate using the neighbour to the left
            this.Calculate(this.GetInput(), -1);
        }
    }
}
