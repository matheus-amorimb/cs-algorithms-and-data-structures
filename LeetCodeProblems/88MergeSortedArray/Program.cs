int[] nums1 = [1, 2, 3, 0, 0, 0];
int m = 3;
int[] nums2 = [2, 5, 6];
int n = 3;

Solution(nums1, m, nums2, n);

static void Solution(int[] nums1, int m, int[] nums2, int n)
{
    var part1 = nums1[0.. (m)];
    var part2 = nums2[0.. (n)];

    part1.CopyTo(nums1, 0);
    part2.CopyTo(nums1, part1.Length);

    Array.Sort(nums1);
}