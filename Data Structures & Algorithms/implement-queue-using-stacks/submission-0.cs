public class MyQueue {
    private Stack<int> stack;
    private Stack<int> temp;
    public MyQueue() {
        stack = new Stack<int>();
        temp = new Stack<int>();
    }
    
    public void Push(int x) {
        while(stack.Count > 0) {
            temp.Push(stack.Pop());
        }
        stack.Push(x);
        while(temp.Count > 0) {
            stack.Push(temp.Pop());
        }
    }
    
    public int Pop() {
        return stack.Pop();
    }
    
    public int Peek() {
        return stack.Peek();
    }
    
    public bool Empty() {
        return stack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */