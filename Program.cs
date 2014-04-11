using System;
using System.Diagnostics;
using TimeComplexityLimits.Computations;

namespace TimeComplexityLimits
{
    class Program
    {
        public static void Main()
        {
            Measure(new LinearComplexityComputation());
            Measure(new SquareComplexityComputation());
            Measure(new CubicComplexityComputation());
            Measure(new LogComplexityComputation());
            Measure(new ExponentialComplexityComputation());
            Measure(new FactorialComplexityComputation());

            Console.ReadLine();
        }

        static void Measure(IComputation computation)
        {
            var chrono = new Stopwatch();

            Console.Write("{0}\t", computation.Name);

            chrono.Start();
            var n = computation.Run();
            chrono.Stop();

            Console.Write(n >= 1000 ? "N={0:e0}" : "N={0}", n);

            Console.WriteLine("\t{0:F1} seconds", chrono.Elapsed.TotalSeconds);
        }
    }
}
