string haystack = "sadbutsad";
string needle = "sadaaaaaaaaaaaaaaaaaaa";

Console.WriteLine(StrStr(haystack, needle));

//BRUTAL FORCE
static int StrStr(string haystack, string needle)
{
    int haystackLen = haystack.Length;
    int needleLen = needle.Length;
    string substring;

    for (int i = 0; i <= haystackLen - needleLen; i++)
    {
        substring = haystack.Substring(i, needleLen);
        if (substring == needle)
        {
            return i;
        }
    }
    return -1;
}

//Knuth-Morris-Pratt (KMP)
static int KMP(string haystack, string needle)
{
    int haystackLen = haystack.Length;
    int needleLen = needle.Length;
         
    for (int i = 0; i < haystack.Length; i++)
    {
        
    }   
    
    
    return -1;
}