using System;
using System.Runtime.CompilerServices;

namespace TimeComplexityLimits.Computations
{
    class LogComplexityComputation : IComputation
    {
        public string Name
        {
            get { return "O(n*log(n))"; }
        }

        public long Run()
        {
            const long n = 500000000;

            RecursiveComputation(n);

            return n;
        }

        void RecursiveComputation(long n)
        {
            for (long i = 0; i < n; i++)
            {
                ComputationHelpers.EmptyMethod();
            }

            if (n > 1)
            {
                RecursiveComputation(n/2);
            }
        }
    }
}