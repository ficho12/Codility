using System;

class Solution {
    public int solution(int[] A) {
        int n = A.Length;
        int[] temp = new int[n];
        return MergeSort(A, temp, 0, n - 1);
    }

    private int MergeSort(int[] A, int[] temp, int left, int right) {
        if (left >= right) {
            return 0;
        }

        int mid = (left + right) / 2;
        int inversions = MergeSort(A, temp, left, mid) + MergeSort(A, temp, mid + 1, right);

        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right) {
            if (A[i] <= A[j]) {
                temp[k++] = A[i++];
            } else {
                temp[k++] = A[j++];
                inversions += mid - i + 1;
            }

            if (inversions > 1000000000) {
                return -1;
            }
        }

        while (i <= mid) {
            temp[k++] = A[i++];
        }

        while (j <= right) {
            temp[k++] = A[j++];
        }

        Array.Copy(temp, left, A, left, right - left + 1);

        return inversions;
    }
}