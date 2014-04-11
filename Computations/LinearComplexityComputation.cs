namespace TimeComplexityLimits.Computations
{
    class LinearComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(n)"; }
        }

        public long Run()
        {
            const long n = 1000000000;

            for (long i = 0; i < n; i++)
            {
                ComputationHelpers.EmptyMethod();
            }

            return n;
        }
    }
}