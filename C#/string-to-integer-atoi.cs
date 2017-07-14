public class Solution
{
    public int MyAtoi(string str)
    {
        if (str == null || str.Length < 1) return 0;
        str = str.Trim();
        char flag = '+';
        int i = 0;
        if (str[0] == '-') { flag = '-'; i++; }
        else if (str[0] == '+') i++;
        double sum = 0;
        while (str.Length > i && str[i] >= '0' && str[i] <= '9')
        {
            sum = sum * 10 + (str[i] - '0');
            i++;
        }
        if (flag == '-') sum = -sum;
        if (sum > int.MaxValue) return int.MaxValue;
        if (sum < int.MinValue) return int.MinValue;
        return (int)sum;
    }
}
