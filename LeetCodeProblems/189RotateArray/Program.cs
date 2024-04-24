List<int> nums = new List<int>() {1,2,3,4,5,6,7};

List<int> numsRotated = RotateArray2(nums, 3);

foreach (var num in numsRotated)
{
    Console.Write($"{num}, ");
}

 static List<int> RotateArray(List<int> nums, int k)
 {
     if (k == 0)
     {
         return nums;
     }
     
     if (k == 1)
     {
         int lastValue = nums[nums.Count - 1];

         for (int i = nums.Count - 1; 1 <= i; i--)
         {
             nums[i] = nums[i - 1];
             
         }

         nums[0] = lastValue;

         return nums;
     }

     k--;
     
     return RotateArray(RotateArray(nums, 1), k);
 }

 static List<int> RotateArray2(List<int> nums, int k)
 {

     List<int> leftSide = nums.GetRange(0, nums.Count() - k);
     List<int> rigthSide = nums.GetRange(nums.Count() - k, k);

     for (int i = 0; i < k; i++)
     {
        nums[i] = rigthSide[i];
     }
     
     for (int i = 0; i < nums.Count() - k; i++)
     {
         nums[k + i] = leftSide[i];
     }
     
     return nums;
 }