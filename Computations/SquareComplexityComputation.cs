namespace TimeComplexityLimits.Computations
{
    class SquareComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(n²)"; }
        }

        public long Run()
        {
            const long n = 30000;

            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    ComputationHelpers.EmptyMethod();
                }
            }

            return n;
        }
    }
}