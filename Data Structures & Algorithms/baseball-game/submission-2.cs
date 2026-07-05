public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();

        foreach(string op in operations) {
            switch(op) {

                case "+":
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newTop);
                break;

                case "D":
                    stack.Push(stack.Peek() * 2);
                break;

                case "C":
                    stack.Pop();
                break;

                default:
                    stack.Push(int.Parse(op));
                break;
            }
        }

        int sum = 0;
        while (stack.Count > 0) {
            sum += stack.Pop();
        }

        return sum;
    }
}