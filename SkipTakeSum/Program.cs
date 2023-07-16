class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<double> { 1.02, 2.1, 3.5, 0.4, 53, 6.0, 7.6, 8.5, 9.2 };
        var skipTakeSum = new SkipTakeSumAvg();
        skipTakeSum.Sum(numbers);
        skipTakeSum.Avg(numbers);
        skipTakeSum.Counting(numbers);
    }
}
