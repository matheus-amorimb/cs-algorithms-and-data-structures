string roman = "MCMXCIV";

Console.WriteLine(RomanToInt(roman));

static int RomanToInt(string s)
{
    Dictionary<char, int> romanInts = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    int romanToInt = 0;
    int previousValue = 0;    
    
    for (int i = 0; i < s.Length; i++)
    {   
        int valueToAdd = romanInts[s[i]];

        if (valueToAdd > previousValue) 
        {
            valueToAdd += -(2 * previousValue);
        }
            
        romanToInt += valueToAdd;
        previousValue = valueToAdd;
    }
         
    return romanToInt;
}