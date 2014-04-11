namespace TimeComplexityLimits.Computations
{
    class ExponentialComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(2^n)"; }
        }

        public long Run()
        {
            const int n = 30;

            for (long i = 0; i < 1<<n; i++)
            {
                ComputationHelpers.EmptyMethod();
            }

            return n;
        }
    }
}