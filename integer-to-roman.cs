public class Solution
{
    public string IntToRoman(int num)
    {
        if (num <= 0) return "";
        int[] nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        StringBuilder sb = new StringBuilder();
        int digit = 0;
        while (num > 0)
        {
            int times = num / nums[digit];
            num -= nums[digit] * times;
            for (; times > 0; times--) sb.Append(symbols[digit]);
            digit++;
        }
        return sb.ToString();
    }
}
