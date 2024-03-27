List<int> numbersToSort = new List<int>() { 17, 17, 23, 9, 12, 30, 8, 41, 3, 19, 14, 27, 10, 6, 38 };

List<int> sortedList = SelectionSort(numbersToSort, "descending");

Console.Write($"[");
foreach (var num in sortedList)
{
    Console.Write($"{num}, ");
}
Console.Write($"]");

static int MinValue(List<int> list)
{
    int minValueIndex = 0;
    int minValue = list[minValueIndex];
    
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] <= minValue)
        {
            minValue = list[i];
            minValueIndex = i;
        }
    }
    return minValueIndex;
}

static int MaxValue(List<int> list)
{
    int maxValueIndex = 0;
    int maxValue = list[maxValueIndex];
    
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] >= maxValue)
        {
            maxValue = list[i];
            maxValueIndex = i;
        }
    }
    return maxValueIndex;
}

static List<int> SelectionSort(List<int> listToSort, string order)
{

    Dictionary<string, Func<List<int>, int>> orders = new Dictionary<string, Func<List<int>, int>>(0)
    {
        {"ascending", MinValue},
        {"descending", MaxValue} 
    };
    
    List<int> sortedList = new List<int>();
    int listLength = listToSort.Count();
    
    if (!orders.ContainsKey(order))
    {
        throw new ArgumentException("Invalid order specified.");
    }
    
    for (int i = 0; i < listLength; i++)
    {
        int index = orders[order](listToSort);
        sortedList.Add(listToSort[index]);
        listToSort.RemoveAt(index);
    }
    return sortedList;
}