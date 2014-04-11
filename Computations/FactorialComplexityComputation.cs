namespace TimeComplexityLimits.Computations
{
    class FactorialComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(n!)"; }
        }

        public long Run()
        {
            const int n = 11;

            RecursiveMethod(n);

            return n;
        }
        
        void RecursiveMethod(int n)
        {
            if (n == 0) return;

            for (int i = 0; i < n; i++)
            {
                ComputationHelpers.EmptyMethod();
                RecursiveMethod(n - 1);
            }
        }
    }
}