List<int> nums = [5, 7, 7, 8, 8, 10];
int target = 8;

Console.WriteLine(Solution(nums, target));

static int[] Solution(List<int> nums, int target)
{
    int top = nums.Count - 1;
    int bottom = 0;
    int i = -1;
    int j = -1;
    
    while (bottom <= top)
    {
        int middle = (top + bottom) / 2;
        int guess = nums[middle];

        if (guess == target)
        {
            i = middle - 1;
            j = middle + 1;
            
            //Left pointer
            guess = nums[i];
            while (i > 0 && guess == target)
            {
                i--;
                guess = nums[i];

            }
            
            //Right pointer
            guess = nums[j];
            while (j < nums.Count - 1 && guess == target)
            {
                j++;
                guess = nums[i];

            }
            
            return new int[] {i, j};
            // int rightIndex = middle + 1;
            // int leftIndex = middle - 1;
            //
            // int right = nums[rightIndex];
            // int left = nums[leftIndex];
            //
            // while (right != target && left != target)
            // {
            //     if (right == target)
            //     {
            //         j = rightIndex;
            //     }    
            //     if (left == target)
            //     {
            //         i = leftIndex;
            //     }
            //     
            //     rightIndex++;
            //     leftIndex--;
            //     
            //     right = nums[rightIndex];
            //     left = nums[leftIndex];
            // }

            Console.WriteLine($"{i}, {j}");
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