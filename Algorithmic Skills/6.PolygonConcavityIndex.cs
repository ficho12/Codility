using System;
// NO USAR NO FUNCIONA

class Point2D {
    public int x;
    public int y;
}

class Solution {
    public int solution(Point2D[] A) {
        int n = A.Length;
        int[] hull = new int[n];
        int k = 0;

        for (int i = 0; i < n; i++) {
            while (k >= 2 && cross(hull[k - 2], hull[k - 1], i, A) <= 0) {
                k--;
            }
            hull[k++] = i;
        }

        for (int i = n - 2, t = k + 1; i >= 0; i--) {
            while (k >= t && cross(hull[k - 2], hull[k - 1], i, A) <= 0) {
                k--;
            }
            hull[k++] = i;
        }

        int[] convexHull = new int[k];
        Array.Copy(hull, convexHull, k);

        for (int i = 0; i < n; i++) {
            if (!Array.Exists(convexHull, j => j == i))
                return i;
        }

        return -1;
    }

    private long cross(int i, int j, int k, Point2D[] A) {
        return (long)(A[j].x - A[i].x) * (A[k].y - A[i].y) - (long)(A[j].y - A[i].y) * (A[k].x - A[i].x);
    }
}