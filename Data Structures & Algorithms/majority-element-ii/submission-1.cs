public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int tSize = nums.Length / 3;
        Dictionary<int, int> map = new();
        List<int> res = new();
        foreach (var num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }
            if (map[num] >= 0) {
                map[num]++;
            }
            if (map[num] > tSize) {
                res.Add(num);
                map[num] = -1;
            }

        }
        return res;
        
    }
}