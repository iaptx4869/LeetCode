public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var hasttable = new Hashtable();
        for (var i = 0; i < nums.Length; i++)
        {
            int x = nums[i];
            if (hasttable.ContainsKey(target - x))
            {
                return new int[] { (int)hasttable[target - x] + 1, i + 1 };
            }
            if (!hasttable.ContainsKey(x))
            {
                hasttable.Add(x, i);
            }
        }
        return new int[] { 0, 0 };
    }
}
