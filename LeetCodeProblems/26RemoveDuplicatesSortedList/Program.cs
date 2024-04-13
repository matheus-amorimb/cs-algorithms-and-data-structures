int[] nums = new[] {0, 1, 2, 3, 3, 3, 4, 5, 5, 6, 6, 6, 7};

RemoveDuplicates(nums);

static int RemoveDuplicates(int[] nums)
{
    int j = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[j] = nums[i];
            j++;
        }
    }
    
    foreach (var num in nums)
    {
        Console.Write($"{num}; ");
    }
    
    Console.WriteLine();
    
    return 0;
}