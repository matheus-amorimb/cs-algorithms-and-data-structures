int[] nums = new[] {1,1,1,2,2,2,3};

RemoveDuplicates(nums);

static int RemoveDuplicates(int[] nums)
{
    int k = 2;
    int a = nums[2];
    int b = nums[0];
    int c = b;
    
    for (int i = 2; i < nums.Length; i++)
    {
        a = nums[i];
        b = nums[i - 2];
        if (c != b)
        {
            b = c;
        }
        if (a != b)
        {
            c = nums[i - 2];
            nums[k] = nums[i];
            k++;
        }
    }
    
    foreach (var num in nums)
    {
        Console.Write($"{num}; ");
    }
    
    Console.WriteLine();


    return 0;
}