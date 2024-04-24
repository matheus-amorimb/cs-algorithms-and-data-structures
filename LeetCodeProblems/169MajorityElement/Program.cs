
List<int> nums = new List<int>() { 3, 2, 3 };

Console.WriteLine(MajorityElement(nums));

static int MajorityElement(List<int> nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    int numsLength = nums.Count;

    for (int i = 0; i < numsLength; i++)
    {
        if (dict.ContainsKey(nums[i]))
        {
            int currentCounter = dict[nums[i]];
            currentCounter++;

            if (currentCounter > numsLength/2)
            {
                return nums[i];
            }
            
            dict[nums[i]] = currentCounter;
        }
        else
        {
            dict.Add(nums[i], 1);
        }
        
    }

    return nums[0];
}