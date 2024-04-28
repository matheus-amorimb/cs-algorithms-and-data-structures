
string s = "a";

static int LengthOfLastWord(string s)
{
    int positionLastChar = s.Length -1;
    int lengthLastWord = 0;
    char lastChar = s[positionLastChar];
        
    while (lastChar == ' ')
    {
        positionLastChar--;
        lastChar = s[positionLastChar];
    }

    while (lastChar != ' ')
    {
        lengthLastWord++;
        positionLastChar--;
        if(positionLastChar == -1)
        {
            break; 
        }
        lastChar = s[positionLastChar];
    }

    return lengthLastWord;
}