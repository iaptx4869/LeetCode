public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows <= 1) return s;
        string result = "";
        int step = 2 * (numRows - 1);
        for (int row = 0; row < numRows; row++)
        {
            for (int j = row; j < s.Length; j += step)
            {
                result += s[j];
                if (row == 0 || row == numRows - 1) continue;
                int slash = j + step - 2 * row;
                if (slash < s.Length) result += s[slash];
            }
        }
        return result;
    }
}
