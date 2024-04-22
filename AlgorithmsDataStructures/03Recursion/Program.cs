//Função soma de forma recursiva

List<int> list = new List<int>() { 1, 2, 3, 4 };

Console.WriteLine("============= SumRecursive =============");
Console.WriteLine(SumRecursive(list));

static int SumRecursive(List<int> list)
{
    if (list.Count == 0)
    {
        return 0;
    }
    return list[0] + SumRecursive(list.GetRange(1, list.Count - 1));;
}

//Função conta número de itens de forma recursiva
List<int> list2 = new List<int>() { 1, 2, 3, 4 };


Console.WriteLine("============= CountRecursive =============");
Console.WriteLine(CountRecursive(list2));

static int CountRecursive(List<int> list)
{
    
    if (list.Count == 0)
    {
        return 0;
    }
    
    list.RemoveAt(0);

    return 1 + CountRecursive(list);
}

//Função encontra o valor mais alto numa lista de forma recursiva
List<int> list3 = new List<int>() { 1, 200, 201, 4, 5 };

Console.WriteLine("============= GreaterValueRecursive =============");
Console.WriteLine(GreaterValueRecursive(list3));

static int GreaterValueRecursive(List<int> list)
{
    if (list.Count == 2)
    {
        return list[0] >= list[1] ? list[0] : list[1];
    }

    int sub_max = GreaterValueRecursive(list.GetRange(1, list.Count - 1));
    
    return list[0] >= sub_max
        ? list[0]
        : sub_max;
}

//Binary Search de forma recursiva