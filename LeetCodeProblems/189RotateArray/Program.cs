List<int> nums = new List<int>() {1, 2};

List<int> numsRotated = RotateArray(nums, 55000);

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