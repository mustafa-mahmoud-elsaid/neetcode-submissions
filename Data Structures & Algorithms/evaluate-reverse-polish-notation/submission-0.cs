public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string token in tokens) {
            if(int.TryParse(token, out int num)) {
                stack.Push(num);
                continue;
            }
            int operand2 = stack.Pop(), operand1 = stack.Pop();
            int subResult = GetValue(operand1, operand2, token[0]);
            stack.Push(subResult);
        }
        return stack.Pop();
    }
    private int GetValue(int num1, int num2, char op) {
        return op switch {
            '+' => num1 + num2,
            '*' => num1 * num2,
            '-' => num1 - num2,
            _ => num1 / num2,
        };
    }
}
