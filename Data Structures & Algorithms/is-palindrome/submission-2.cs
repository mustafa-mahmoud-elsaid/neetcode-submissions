public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length - 1;
        while(l < r) {
            if(!isAlphaNumeric(s[l])) {
                l++;
                continue;
            }
            if(!isAlphaNumeric(s[r])) {
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
    private bool isAlphaNumeric(char c) {
        return (
            (c >= 'A' && c <= 'Z') ||
            (c >= 'a' && c <= 'z') ||
            (c >= '0' && c <= '9')
        );
    }
}
