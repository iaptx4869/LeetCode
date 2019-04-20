public class Solution {
    public int findComplement(int num) {
        return ~num & (Integer.highestOneBit(num) - 1);
    }
}

public class Solution {
    public int findComplement(int num) {
        return ~num + (Integer.highestOneBit(num) << 1);
    }
}