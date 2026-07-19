public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max = piles.Max();
        int k = 1;
        while (k <= max) {
            long totalH = 0;
            foreach (var p in piles) {
                totalH += (int) Math.Ceiling((double) p / k);
            }
            if (totalH <= h) {
                return k;
            }
            k++;
        }
        return -1;
    }
}
