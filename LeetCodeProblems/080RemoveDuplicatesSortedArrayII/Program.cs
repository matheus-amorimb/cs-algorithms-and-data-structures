int[] nums = new[] {0,0,1,1,1,1,2,3,3};

RemoveDuplicatesInPlace(nums);
RemoveDuplicatesWithDict(nums);


static int RemoveDuplicatesInPlace(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    int count;
    int pointer = 0;
    int currentValue = nums[0];
    int counterCurrentValue = 0;
    
    for (int i = 0; i < nums.Length; i++)
    {
        if (currentValue == nums[i])
        {
            counterCurrentValue++;
            if (counterCurrentValue > 2)
            {
                //
            }
            else
            {
                nums[pointer] = nums[i];
                pointer++;
            }
        }
        else
        {
            currentValue = nums[i];
            counterCurrentValue = 1;
            nums[pointer] = nums[i];
            pointer++;
        }
        
    }

    foreach (var num in nums)
    {
        Console.Write($"{num}, ");
    }
    
    return pointer;
}

static int RemoveDuplicatesWithDict(int[] nums)
{
     Dictionary<int, int> dict = new Dictionary<int, int>();
     int count;
     int pointer = 0;

     for (int i = 0; i < nums.Length; i++)
     {
         if (dict.ContainsKey(nums[i]))
         {
             dict.TryGetValue(nums[i], out count);
             if (count == 2)
             {
                 //
             }
             else
             {
                 dict[nums[i]] = 2;
                 nums[pointer] = nums[i];
                 pointer++;
             }
         }
         else
         {
             dict.Add(nums[i], 1);
             nums[pointer] = nums[i];
             pointer++;
         }
     }
     
     foreach (var num in nums)
     {
         Console.Write($"{num}, ");
     }
     
     return pointer;
}