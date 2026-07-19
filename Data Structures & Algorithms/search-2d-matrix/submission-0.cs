public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0, right = matrix.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (target < matrix[mid][0])
            {
                right = mid - 1;
            }
            else if (target > matrix[mid][matrix[mid].Length - 1])
            {
                left = mid + 1;
            }
            else
            {
                return SearchArray(matrix[mid], target);
            }
        }

        return false;
    }

    private bool SearchArray(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return true;

            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}