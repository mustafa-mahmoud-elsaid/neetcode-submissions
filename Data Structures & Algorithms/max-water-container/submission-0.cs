public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int l = 0, r = height.Length - 1;
        while(l < r) {
            int minHeigth = Math.Min(height[l], height[r]);
            max = Math.Max(max, minHeigth * (r - l));

            if(height[l] < height[r]) {
                l++;
            } else {
                r--;
            }
        }
        return max;
    }
}