public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new();
        List<int> perm = new();
        bool[] exists = new bool[nums.Length];
        void Backtrack() {
            if (perm.Count == nums.Length) {
                res.Add(perm.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++) {
                if (exists[i]) continue;
                perm.Add(nums[i]);
                exists[i] = true;
                Backtrack();
                perm.RemoveAt(perm.Count - 1);
                exists[i] = false;
            }
        }
        Backtrack();
        return res;
    }
}
