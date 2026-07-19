public class Solution {
    public int MySqrt(int x) {
        if(x <= 1) {
            return x;
        } 
        int l = 1; int r = x;
        int res = 0;
        while (l <= r) {
            int mid = l + (r - l) / 2;
            long sq = (long) mid * mid;
            if (sq == x) {
                return mid;
            }
            else if (sq < x) {
                res = Math.Max(res, mid);
                l = mid + 1;
            } else {
                r = mid - 1;
            }
        }
        return res;
    }
}