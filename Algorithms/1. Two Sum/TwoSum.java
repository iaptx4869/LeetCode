public class TwoSum {
    public static void main(String[] args) {
        int[] nums = { 3, 2, 4 };
        int[] ans = new Solution().twoSum(nums, 6);
        for (int i : ans)
            System.out.println(i);
    }
}