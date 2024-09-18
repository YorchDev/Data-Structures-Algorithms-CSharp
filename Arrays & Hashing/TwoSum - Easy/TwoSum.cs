class Solution
{
    int[] TwoSum(int[] nums, int target)
    {
        //HashMap approach: 
        Dictionary<int, int> hashmap = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (hashmap.ContainsKey(diff)) {
                return new int[] {i, hashmap[diff] };
            }

            hashmap[nums[i]] = i;

        }
        throw new ArgumentException("No two sum solution");
    }
}