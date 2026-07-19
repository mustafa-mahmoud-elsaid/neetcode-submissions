public class Solution {
    public int FindMin(int[] nums) {
        int result = nums[0];
        int l = 0; int r = nums.Length - 1;
        while (l <= r) {
            if (nums[l] < nums[r]) {
                result = Math.Min(result, nums[l]);
                break;
            }
            int m = l + (r - l) / 2;
            result = Math.Min(result, nums[m]);
            if (nums[m] >= nums[l]) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return result;
    }
}