public class Solution {
    private bool IsOpening(char c) {
        return c == '(' || c == '{' || c == '[';
    }
    private bool IsComplement(char open, char close) {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        for(int i = 0; i < s.Length; ++i) {
            if(IsOpening(s[i])) {
                st.Push(s[i]);
            } else {
                if(st.Count != 0 && IsComplement(st.Peek(), s[i])) {
                    st.Pop();
                } else {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}