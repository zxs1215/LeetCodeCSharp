public class Solution {
    public int SingleNumber(int[] A) {
        if (A == null || A.Length ==0)
            return 0;
        int result = A[0];
        
        for(int i = 1; i < A.Length; i++){
            result = result ^ A[i];
        }
        return result;
    }
}