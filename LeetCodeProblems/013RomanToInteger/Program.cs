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
    
    for (int i = 0; i < s.Length; i++)
    {
        int valueToAdd = romanInts[s[i]];

        if (i != s.Length - 1)
        {
            if (
                s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X') ||
                s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C') ||
                s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M')
                )
            {
                valueToAdd = -romanInts[s[i]];
            }
        }
        
        romanToInt += valueToAdd;
    }
    
    return romanToInt;
}