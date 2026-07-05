public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int result = 0;
        foreach(string s in operations) {
            if(s == "D") {
                stack.Push(2 * stack.Peek());
            }
            else if(s == "C") {
                stack.Pop();
            }
            else if(s == "+") {
                int num1 = stack.Pop();
                int num2 = stack.Peek();

                stack.Push(num1);
                stack.Push(num1 + num2);
            }
            else {
                stack.Push(int.Parse(s));
            }
        }
        while(stack.Count > 0) {
            result += stack.Pop();
        }
        return result;

    }
}