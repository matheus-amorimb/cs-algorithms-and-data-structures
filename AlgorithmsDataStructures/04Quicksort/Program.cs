//Função soma de forma recursiva

List<int> list = new List<int>() { 1, 2, 3, 4 };

Console.WriteLine(SumRecursive(list));

static int SumRecursive(List<int> list)
{
    int sum = 0;
    
    if (list.Count == 0)
    {
        return 0;
    }
    
    if (list.Count == 1)
    {
        return list[0];
    }
    
    return list[0] + SumRecursive(list.GetRange(1, list.Count - 1));;
}

//Função conta número de itens de forma recursiva
List<int> list2 = new List<int>() { 1, 2, 3, 4 };

Console.WriteLine(CountRecursive(list2));

static int CountRecursive(List<int> list)
{
    
    if (list.Count == 1)
    {
        return 1;
    }
    
    list.RemoveAt(0);

    return 1 + CountRecursive(list);
}