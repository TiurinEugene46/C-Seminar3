int[] nums = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 30};
int max = nums[0];
for(int i = 0; i < nums.Length; i++) // индекс = 0, индекс < 10, индекс = индекс + 1
{
    if(nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine(max);