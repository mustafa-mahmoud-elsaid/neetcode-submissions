public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new();
        List<int> cur = new();
        void Backtrack(int start) {
            res.Add(cur.ToList());

            for (int i = start; i < nums.Length; i++) {
                cur.Add(nums[i]);
                Backtrack(i + 1);
                cur.RemoveAt(cur.Count - 1);
            }
        }
        Backtrack(0);

        return res;
    }
}
