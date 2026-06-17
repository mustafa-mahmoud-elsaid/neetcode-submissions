public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var boxSets = new HashSet<char>[9];
        var colSets = new HashSet<char>[9];
        for(int i = 0; i < 9; ++i) {
            boxSets[i] = new();
            colSets[i] = new();
        }
        for(int i = 0; i < board.Length; ++i){
            var rowSet = new HashSet<char>();
            for(int j = 0; j < board[i].Length; ++j){
                var current = board[i][j];
                if(current == '.')
                    continue;
                var group = GetBoxGroup(i, j);
                if(rowSet.Contains(current) ||
                    colSets[j].Contains(current) || 
                     boxSets[group].Contains(current)
                    )
                    return false;
                rowSet.Add(current);
                boxSets[group].Add(current);
                colSets[j].Add(current);
            }
        }
        return true;
    }
    private int GetBoxGroup(int row, int col) {
        return (row / 3) * 3 + (col / 3);
    }
}
