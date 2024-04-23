 List<int> list = new List<int>() { 1, 200, 201, 105, 99, -1, 2, 7, 93};
 
 Console.WriteLine("============= Quicksort =============");
List<int> sortedList = QuickSort(list);

 foreach (var value in sortedList)
 {
     Console.Write($"{value} ");
 }
 
 static List<int> QuickSort(List<int> list)
 {
     List<int> sortedList = new List<int>();
     
     if (list.Count < 2)
     {
         return list;
     }

     List<int> partialLeft = new List<int>();
     List<int> partialRight = new List<int>();
     
     int pivot = list[0];

     for (int i = 1; i < list.Count; i++)
     {
         if (list[i] < pivot)
         {
             partialLeft.Add(list[i]);
         }
         else
         {
             partialRight.Add(list[i]);
         }
     }

     partialLeft = QuickSort(partialLeft);
     partialRight = QuickSort(partialRight);

     sortedList = partialLeft.Append(pivot).ToList();
     sortedList = sortedList.Concat(partialRight).ToList();
     
     return sortedList;
 }
