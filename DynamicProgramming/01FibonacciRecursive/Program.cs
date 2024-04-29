var watch = System.Diagnostics.Stopwatch.StartNew();

Console.WriteLine(FibonacciRecursive(55));

watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;

Console.WriteLine($"Time: {elapsedMs}ms");

static int FibonacciRecursive(int n)
{
    if (n < 3)
    {
        return 1;
    }    
    
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}
