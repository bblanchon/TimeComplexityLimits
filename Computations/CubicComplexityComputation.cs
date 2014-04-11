namespace TimeComplexityLimits.Computations
{
    class CubicComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(n\x00B3)"; }
        }

        public long Run()
        {
            const long n = 1000;

            for (long i = 0; i < n; i++)
            {
                for (long j = 0; j < n; j++)
                {
                    for (long k = 0; k < n; k++)
                    {
                        ComputationHelpers.EmptyMethod();
                    }
                }
            }

            return n;
        }
    }
}