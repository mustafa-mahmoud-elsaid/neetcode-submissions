public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> map = new();
        int hSize = nums.Length / 2;
        foreach (var num in nums) {
            if (map.ContainsKey(num)) {
                map[num]++;
                if (map[num] > hSize) {
                    return num;
                }
            } else {
                map[num] = 1;
            }
        }
        return nums[0];
    }
}