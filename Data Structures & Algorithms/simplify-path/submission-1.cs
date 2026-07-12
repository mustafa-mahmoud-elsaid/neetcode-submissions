public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> s = new Stack<string>();
        StringBuilder curr = new StringBuilder();
        path += '/';
        foreach (var c in path) {
            if(c == '/') {
                string currString = curr.ToString(); 
                if(currString == "..") {
                    if(s.Count > 0) s.Pop();
                }
                else if (currString != "" && currString != ".") {
                    s.Push(currString);
                }
                curr.Clear();
            } else {
                curr.Append(c);
            }
        }
        var result = new List<string>(s);
        result.Reverse();
        return "/" + string.Join("/", result);
    }
}