public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        foreach(int a in asteroids) {
            int current = a;
            while(stack.Count > 0 && current < 0 && stack.Peek() > 0) {
                int diff = current + stack.Peek();
                
                // right won 
                if (diff > 0) {
                    current = 0;
                } else if (diff < 0) { // left won
                    stack.Pop();
                } else { // equal
                    stack.Pop();
                    current = 0;
                }
            }
            if (current != 0) {
                stack.Push(current);
            }
        }

        return stack.Reverse().ToArray();
    }
}