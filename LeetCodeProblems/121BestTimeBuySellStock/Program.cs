int[] prices = new int[] {7,6,4,3,1};

Console.WriteLine(MaxProfit(prices));

static int MaxProfit(int[] prices)
{
    int lowestValue = int.MaxValue;
    int highestValue = int.MaxValue;
    int maxProfit = 0;
    
    foreach (var price in prices)
    {
        (highestValue, lowestValue) = price < lowestValue ? 
            (price, price) : 
            (highestValue, lowestValue);
        
        highestValue = price > highestValue ? price : highestValue;
        
        int currentProfit = highestValue - lowestValue;

        maxProfit = currentProfit > maxProfit ? currentProfit : maxProfit;
        
    }

    return maxProfit > 0 ? maxProfit : 0;
    
}