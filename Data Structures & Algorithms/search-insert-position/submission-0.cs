public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0; int r = nums.Length - 1;
        while (l <= r) {
            int m = (l + r) / 2;
            if(target == nums[m]) return m;
            if (nums[m] < target) {
                l = m + 1;
            }
            else {
                r = m - 1;
            }
        }
        return l;
    }
}