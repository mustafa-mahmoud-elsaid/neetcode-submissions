public class Solution {
    public int MaxProfit(int[] prices) {
       int maxSoFar = 0;
       int buyPrice = prices[0];

       foreach (var price in prices) {
        if (price < buyPrice) {
            buyPrice = price;
            continue;
        }
        maxSoFar = Math.Max(maxSoFar, price - buyPrice);
       }
       return maxSoFar;
    }
}
