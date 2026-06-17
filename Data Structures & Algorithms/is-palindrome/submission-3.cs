public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        while(l < r) {
            if(!Char.IsLetterOrDigit(s[l])) {
                l++;
                continue;
            }
            if(!Char.IsLetterOrDigit(s[r])) {
                r--;
                continue;
            }
            if(char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }
            l++;r--;
        }
        return true;
    }
}
