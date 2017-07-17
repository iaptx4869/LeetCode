public class KeyboardRow {
    public static void main(String[] args) {
        String[] input = { "Hello", "Alaska", "Dad", "Peace" };
        String[] output = new Solution().findWords(input);
        for (String i : output)
            System.out.println(i);
    }
}