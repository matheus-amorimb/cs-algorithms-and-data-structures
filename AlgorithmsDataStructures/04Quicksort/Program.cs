 List<int> list = new List<int>() { 1, 200, 201, 105, 99, -1, 2, 7, 93};
 
 Console.WriteLine("============= Quicksort =============");
List<int> sortedList = QuickSort(list);

 foreach (var value in sortedList)
 {
     Console.Write($"{value} ");
 }
 
 static List<int> QuickSort(List<int> list)
 {
     if (list.Count < 2)
     {
         return list;
     }

     List<int> partialLeft = new List<int>();
     List<int> partialRight = new List<int>();

     var random = new Random();
     var randomIndex = random.Next(list.Count - 1);
     int pivot = list[randomIndex];

     for (int i = 0; i < list.Count; i++)
     {
         if (i != randomIndex)
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
     }

     partialLeft = QuickSort(partialLeft);
     partialRight = QuickSort(partialRight);

     partialLeft.Add(pivot);
     partialLeft.AddRange(partialRight);
     
     return partialLeft;
 }
