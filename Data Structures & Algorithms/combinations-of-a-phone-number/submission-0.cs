public class Solution {
    public List<string> LetterCombinations(string digits) {
        List<string> res = new();

        if (digits.Length == 0) return res;

        Dictionary<char, string> digitToChar = new() {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        void Backtrack(int i, string cur) {
            if (cur.Length == digits.Length) {
                res.Add(cur);
                return;
            }
            foreach (var c in digitToChar[digits[i]]) {
                Backtrack(i + 1, cur + c);
            }
        }
        Backtrack(0, string.Empty);

        return res;
    }
}
