public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var lcp = new StringBuilder("");
        for (int i = 0; i < strs[0].Length; ++i) {
            for(int j = 1; j < strs.Length; ++j) {
                if (strs[j].Length <= i || strs[j][i] != strs[0][i])
                    return lcp.ToString();
            }
            lcp.Append(strs[0][i]);
        }
        return lcp.ToString();
    }
}