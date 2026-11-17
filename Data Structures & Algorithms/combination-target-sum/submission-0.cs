public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new();
        int sum = 0;
        List<int> cur = new();

        void Backtrack(int start) {
            if (sum == target) {
                res.Add(cur.ToList());
                return;
            }

            for (int i = start; i < nums.Length; i++) {
                if (sum + nums[i] > target) continue;

                cur.Add(nums[i]);
                sum += nums[i];
                Backtrack(i);
                sum -= nums[i];
                cur.RemoveAt(cur.Count - 1);
            }
        }
        Backtrack(0);
        return res;
    }
}
