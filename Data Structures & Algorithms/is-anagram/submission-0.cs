public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] freqArrS = new int[26];
        int[] freqArrT = new int[26];
        for(int i = 0; i < s.Length; ++i){
            freqArrS[s[i] - 'a'] += 1; 
            freqArrT[t[i] - 'a'] += 1; 
        }
        for(int i =0; i < freqArrS.Length; ++i)
            if(freqArrS[i] != freqArrT[i])
                return false;
        return true;
    }
}
/*
 * [0, 2, 1 , 0, ---]
 * [0, 2, 1 , 0, ---]
*/