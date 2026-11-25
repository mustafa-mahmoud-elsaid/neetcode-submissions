public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        var cols = new HashSet<int>();
        var posDiagonals = new HashSet<int>();
        var negDiagonals = new HashSet<int>();

        List<char[]> board = Enumerable.Range(0, n)
                    .Select(_ => new string('.', n).ToCharArray())
                    .ToList();
        var res = new List<List<string>>();

        void Backtrack(int r) {

            if (r == n) {
                res.Add(board.Select(row => new String(row)).ToList());
                return;
            }

            for (int c = 0; c < n; c++) {
                if (
                    cols.Contains(c) ||
                    posDiagonals.Contains(c + r) ||
                    negDiagonals.Contains(r - c)
                ) {
                    continue;

                }

                cols.Add(c);
                posDiagonals.Add(r + c);
                negDiagonals.Add(r - c);
                board[r][c] = 'Q';
                Backtrack(r + 1);

                cols.Remove(c);
                posDiagonals.Remove(r + c);
                negDiagonals.Remove(r - c);
                board[r][c] = '.';
            }
        }
        Backtrack(0);
        return res;
    }
}
