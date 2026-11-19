public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> res = new();
        List<int> sub = new();

        Array.Sort(nums);

        void Backtrack(int start) {
            res.Add(sub.ToList());

            for (int i = start; i < nums.Length; i++) {
                if (i > start && nums[i] == nums[i - 1]) continue;
                sub.Add(nums[i]);
                Backtrack(i + 1);
                sub.RemoveAt(sub.Count - 1);
            }
        }
        Backtrack(0);
        return res;
    }
}
