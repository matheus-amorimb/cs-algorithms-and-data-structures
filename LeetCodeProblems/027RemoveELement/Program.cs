int[] nums = [4, 5];
int val = 5;

Console.WriteLine(Solution(nums, val));

static int Solution (int [] nums, int val)
{
    int left = 0;
    int right = nums.Length - 1;
    int k = 0;
    
    while (left <= right)
    {
        if (nums[left] == val)
        {
            k++;
            while (nums[right] == val && (right - 1) >= 0 && left != right)
            {
                k++;
                nums[right] = 99;
                right--;
            }

            nums[left] = nums[right];
            nums[right] = 99;
            right--;
        }   
        left++;
    }
    
    Console.WriteLine("Array:");
    foreach (var num in nums)
    {
        Console.Write($"{num}, ");
    }
    Console.WriteLine();
    
    return nums.Length - k;
}