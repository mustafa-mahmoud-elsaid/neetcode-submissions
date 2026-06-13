public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0,  r = nums.Length-1, m = (l+r) / 2;
        while(l <= r){
            if(nums[m] == target)
                return m;
            if(nums[m] < target){
                l = m + 1;
                m = (l+r) / 2;
            }
            else{
               r = m - 1;
                m = (l+r) / 2; 
            }
        }
        return -1;
    }
}
