public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new("");
        foreach(var s in strs){
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {

        int i = 0, j = 0;
        List<string> result = new();
        while (i < s.Length){
            j = i;
            while(s[j] != '#'){
                ++j;
            }
            int length = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            j = i + length;
            result.Add(s.Substring(i, length));
            i = j;
        }
        return result;
   }
}
// 520#HelloHi
//HelloHi025

// 10#----------0#3##hj