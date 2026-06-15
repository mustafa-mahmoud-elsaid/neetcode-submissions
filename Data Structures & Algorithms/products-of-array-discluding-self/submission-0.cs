public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];
        int[] pref = new int[n];
        int[] postf = new int[n];

        pref[0] = 1;
        postf[n - 1] = 1;
        for(int i = 1; i < n; ++i) {
            pref[i] = pref[i - 1] * nums[i - 1];
        }
        for(int i = n - 2; i >= 0; --i) {
            postf[i] = postf[i + 1] * nums[i + 1];
        }
        for(int i = 0; i < n; ++i) {
            result[i] = pref[i] * postf[i];
        }
        return result;
    }
}