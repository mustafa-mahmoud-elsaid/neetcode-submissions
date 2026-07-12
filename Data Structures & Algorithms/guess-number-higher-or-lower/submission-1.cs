/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        return helper(1, n);
    }
    private int helper(int s, int e) {
        int m = s + (e - s) / 2;
        int res = guess(m);
        if (res == 0) {
            return m;
        } else if (res == -1) {
            return helper(s, m - 1);
        } else {
            return helper(m + 1, e);
        }
    }
}