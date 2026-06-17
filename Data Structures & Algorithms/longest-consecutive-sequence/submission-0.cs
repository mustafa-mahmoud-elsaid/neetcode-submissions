public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxSequence = 0;
        foreach(var num in nums){
            if(!set.Contains(num - 1)){
                int inc = 1;
                while(set.Contains(num + inc)){
                    inc++;
                }
                maxSequence = Math.Max(maxSequence, inc);
            }
        }
        return maxSequence;
    }
}