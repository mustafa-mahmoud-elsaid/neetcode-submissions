public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       var dic = new Dictionary<string, List<string>>();
       foreach(var s in strs){
        var freqArr = new int[26];
        for(int i = 0; i < s.Length; ++i){
            freqArr[s[i] - 'a']++;
        }
        string key = string.Join(",", freqArr);
        if(!dic.ContainsKey(key))
            dic.Add(key, new());
        dic[key].Add(s);
       }
       return dic.Values.ToList<List<string>>();
    }
    
}