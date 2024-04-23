int[] nums = new[] {0,0,1,1,1,1,2,3,3};

RemoveDuplicates(nums);


static int RemoveDuplicates(int[] nums)
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