
string haystack = "mississippi";
string needle = "issip";

Console.WriteLine(KnuthMorrisPratt(haystack, needle));

static int KnuthMorrisPratt(string haystack, string needle)
{
    int needleLength = needle.Length;
    int haystackLength = haystack.Length;

    int needleCharPosition = 0;
    int startPosition = -1;
    
    for (int index = 0; index < haystackLength; index++)
    {
        if (needle[needleCharPosition] == haystack[index])
        {
            if (needleCharPosition == needleLength - 1)
            {
                startPosition = index - needleLength + 1;
                break;
            }
            needleCharPosition++;
        }
        else if(needleCharPosition != 0)
        {
            index--;
            needleCharPosition = 0;
        }
    }

    return startPosition;
}