int[] prices = new int[] {7,6,4,3,1};

Console.WriteLine(MaxProfit(prices));

static int MaxProfit(int[] prices)
{
    int lowestValue = int.MaxValue;
    int highestValue = int.MaxValue;
    int maxProfit = 0;
    
    foreach (var price in prices)
    {
        if (price < lowestValue)
        {
            lowestValue = price;
            highestValue = price;
        
        }

        if (price > highestValue)
        {
            highestValue = price;
        }
        
        int currentProfit = highestValue - lowestValue;

        if (currentProfit > maxProfit)
        {
            maxProfit = currentProfit;
        }
    }

    return maxProfit > 0 ? maxProfit : 0;
    
}