using System.Threading.Channels;

string s = "A man, a plan, a canal: Panama";

Console.WriteLine(IsPalindrome(s));

static bool IsPalindrome(string s)
{
    int leftPointer = 0;
    int rigthPointer = s.Length - 1;

    while (leftPointer < rigthPointer)
    {
        char leftChar = char.ToLower(s[leftPointer]);
        char rigthChar = char.ToLower(s[rigthPointer]);
        
        if (!char.IsLetterOrDigit(leftChar))
        {
            leftPointer++;
            continue;
        }

        if (!char.IsLetterOrDigit(rigthChar))
        {
            rigthPointer--;
            continue;
        }

        if (leftChar != rigthChar)
        {
            return false;
        }

        leftPointer++;
        rigthPointer--;
    }

    return true;
}