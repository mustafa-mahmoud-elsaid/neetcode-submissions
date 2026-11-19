public class Solution {
    public bool Exist(char[][] board, string word) {
        int ROWS = board.Length, COLS = board[0].Length;

        bool Backtrack(int row, int col, int i) {
            if (i == word.Length) return true;

            if (row >= ROWS ||
                col >= COLS ||
                row < 0 ||
                col < 0 ||
                word[i] != board[row][col] ||
                word[i] == 'X')
                return false;

            var letter = board[row][col];
            board[row][col] = 'X';
            
            var res = Backtrack(row + 1, col, i + 1) ||
                Backtrack(row - 1, col, i + 1) ||
                Backtrack(row, col + 1, i + 1) ||
                Backtrack(row, col - 1, i + 1);

            board[row][col] = letter;
            return res;
        }

        for (int i = 0; i < ROWS; i++) {
            for (int j = 0; j < COLS; j++) {
                if (Backtrack(i, j, 0)) return true;
            }
        }
        return false;
    }
}
