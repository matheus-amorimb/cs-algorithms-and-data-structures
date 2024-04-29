

Console.WriteLine(FibonacciRecursive(7));

static int FibonacciRecursive(int n)
{
    if (n < 3)
    {
        return 1;
    }    
    
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}