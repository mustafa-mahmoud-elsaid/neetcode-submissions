public class Solution {

    public bool ValidPalindrome(string s) {
        bool isPalindrome(int l, int r) {
            while (l < r) {
                if (s[l] != s[r]) {
                    return false;
                }
                l++;r--;
            }
            return true;
        }

        int l = 0, r = s.Length - 1;
        while (l < r) {
            if (s[l] != s[r]) {
                return isPalindrome(l + 1, r) || isPalindrome(l, r - 1);
            }
            l++;r--;
        }
        return true;
    }
}