public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        (int position, int speed)[] pairs = new (int position, int speed)[position.Length];
        for (int i = 0; i < pairs.Length; ++i) {
            pairs[i] = new(position[i], speed[i]);
        }
        Array.Sort(pairs, (a, b) => b.position.CompareTo(a.position));
        int fleets = 0;
        double lastTime = 0;
        foreach(var pair in pairs) {
            double time = (double) (target - pair.position) / pair.speed;
            if (time > lastTime) {
                fleets++;
                lastTime = time;
            }
        }
        return fleets;
    }
}