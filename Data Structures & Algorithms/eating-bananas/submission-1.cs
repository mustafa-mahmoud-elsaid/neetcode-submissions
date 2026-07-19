public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max(), res = 0;
        while (l <= r) {
            int k = l + (r - l) / 2;
            long total = 0;
            foreach (var p in piles) {
                total += (long) Math.Ceiling((double) p / k);
            }
            if(total <= h) {
                res = k;
                r = k - 1;
            } else {
                l = k + 1;
            }
        }
        return res;
    }
}
