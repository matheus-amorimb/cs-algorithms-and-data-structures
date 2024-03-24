List<string> names = new List<string>
{
    "Alice",
    "Bob",
    "Charlie",
    "David",
    "Emma",
    "Frank",
    "Grace",
    "Henry"
};

string nameToSearch = "Matheus";
Console.WriteLine(BinarySearch(names, nameToSearch));

static int? BinarySearch(List<string> namesList, string name)
{
    int bottom = 0;
    int top = namesList.Count - 1;

    while (bottom <= top)
    {
        //Convert automatically to the lowest int
        int middle = (bottom + top) / 2;
        string guess = namesList[middle];

        if (String.Compare(guess, name) == 0)
        {
            return middle;
        }
        
        //It means the guess is higher than the searched value
        if (String.Compare(guess, name) > 0)
        {
            top = middle - 1;
        }
        //It means the guess is lower than the searched value
        else
        {
            bottom = middle + 1;
        }

    }

    return null;
}