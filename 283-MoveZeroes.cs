public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
        for (int i = 0;i<nums.Length;i++)
        {
            if (nums[i]!=0)
            {
                var temp = nums[index];
                nums[index] = nums[i];
                nums[i] = temp;
                index++;
            }
        }
    }
}