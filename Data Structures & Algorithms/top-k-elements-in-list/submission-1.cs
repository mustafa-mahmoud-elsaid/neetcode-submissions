public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        var pq = new PriorityQueue<int, int>();
        int[] res = new int[k];
        foreach(var n in nums){
            if(!count.ContainsKey(n)){
                count.Add(n, 0);
            }
            count[n]++;
        }
        foreach (var n in count) {
            pq.Enqueue(n.Key, n.Value);
            if (pq.Count > k) {
                pq.Dequeue();
            }
        }
       for (int i = k - 1; i >= 0; --i) {
        res[i] = pq.Dequeue();
       }
       return res;
    }
}