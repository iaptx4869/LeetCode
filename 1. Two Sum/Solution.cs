public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var ht = new Hashtable();
        for (var i = 0; i < nums.Length; i++)
        {
            int x = nums[i];
            if (ht.ContainsKey(target - x)) return new int[] { (int)ht[target - x], i };
            if (!ht.ContainsKey(x)) ht.Add(x, i);

        }
        return new int[] { 0, 0 };
    }
}
