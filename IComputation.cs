namespace TimeComplexityLimits
{
    interface IComputation
    {
        string Name { get; }

        long Run();
    }
}
