public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<(int num, int idx)> stack = new Stack<(int num, int idx)>();

        for(int i = 0; i < temperatures.Length; i++) {
            int term = temperatures[i]; 
            while(stack.Count > 0 && stack.Peek().num < term) {
                var pair = stack.Pop();
                result[pair.idx] = i - pair.idx;
            }
            stack.Push((term, i));
        }
        return result;
    }
}