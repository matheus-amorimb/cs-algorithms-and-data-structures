 List<int> list = new List<int>() { 1, 200, 201, -4, 55, 128, 4};
 
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

     if (list.Count == 2)
     {
         if (list[0] <= list[1])
         {
            (list[0], list[1]) = (list[1], list[0]);
         }

         return list;
     }

     List<int> partialLeft = new List<int>();
     List<int> partialRight = new List<int>();
     
     int pivot = list[0];

     foreach (var num in list)
     {
         if (num < pivot)
         {
             partialLeft.Append(num);
         }
         else
         {
             partialRight.Append(num);
         }
     }

     partialLeft = QuickSort(partialLeft);
     partialRight = QuickSort(partialRight);
     
     return partialLeft.Append(pivot).Concat(partialRight).ToList();
 }
