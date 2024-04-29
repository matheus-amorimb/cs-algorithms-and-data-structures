var watch = System.Diagnostics.Stopwatch.StartNew();

int n = 55;
List<int> fibonacciMemoization = Enumerable.Repeat(0, n + 1).ToList();; 
Console.WriteLine(FibonacciMemoization(n, fibonacciMemoization));

watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;

Console.WriteLine($"Time: {elapsedMs}ms");


static int FibonacciMemoization(int n, List<int> fibonacciMemoization)
{
    if (n < 3)
    {
        return 1;
    }
    
    if (fibonacciMemoization[n] == 0)
    {
        fibonacciMemoization[n] = FibonacciMemoization(n - 1, fibonacciMemoization) + FibonacciMemoization(n - 2, fibonacciMemoization);
    }
    
    return fibonacciMemoization[n];
}

