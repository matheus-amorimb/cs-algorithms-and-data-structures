List<int> nums = [5, 7, 7, 8, 8, 10];
int target = 8;

int[] answer = Solution(nums, target);

Console.WriteLine($"[{string.Join(",", answer)}]");

static int[] Solution(List<int> nums, int target)
{
    int top = nums.Count() - 1;
    int bottom = 0;
    int i = -1;
    int j = -1;
    
    while (bottom <= top)
    {
        int middle = (top + bottom) / 2;
        int guess = nums[middle];

        if (guess == target)
        {
            i = middle;
            j = middle;
            
            //Left pointer
            while (i > 0 && nums[i - 1] == target)
            {
                i--;
                // Console.WriteLine($"i: {i}");
            }
            
            //Right pointer
            while (j < (nums.Count() - 1) && nums[j + 1] == target)
            {
                j++;
                // Console.WriteLine($"j: {j}");
            }
            
            return new int[] {i, j};
        }

        if (guess > target)
        {
            top = middle - 1;
        }
        else
        {
            bottom = middle + 1;
        }
        
    }

    return new int[] {-1, -1};
}