public class Solution
{
    public int Reverse(int x)
    {
        long sum = 0;
        while (x != 0)
        {
            sum = sum * 10 + x % 10;
            x = x / 10;
        }
        if (sum > int.MaxValue || sum < int.MinValue) return 0;
        return (int)sum;
    }
}
