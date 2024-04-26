int[] prices = new int[] {1,2,3,4,5};

Console.WriteLine(MaxProfitII(prices));

static int MaxProfitII(int[] prices)
{
    int lowestValue = int.MaxValue;
    int currentMaxProfit = 0;
    int maxProfit = 0;
    int currentProfit = 0;
    int yesterdayPrice = int.MaxValue;
    
    foreach (var price in prices)
    {
        if (price < yesterdayPrice)
        {
            lowestValue = price;
            maxProfit += currentMaxProfit;
            currentMaxProfit = 0;
        }

        currentProfit = price - lowestValue;
        
        if (currentProfit > currentMaxProfit)
        {
            currentMaxProfit = currentProfit;
            
        }
        
        yesterdayPrice = price;
        
    }

    maxProfit += currentProfit;

    return maxProfit < 0 ? 0 : maxProfit;

}