public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new int[]{};
        var list = new List<Node>();
        for(int i=0;i<nums.Length;i++)
        {
            var node = new Node(i, nums[i]);
            list.Add(node);
        }
        list.Sort((x,y) => x.val.CompareTo(y.val));
        var start = 0;
        var end = nums.Length - 1;
        while(start<end)
        {
            var node1 = list[start];
            var node2 = list[end];
            if(node1.val + node2.val == target)
            {
                var a = node1.index+1;
                var b = node2.index+1;
                if(a>b)
                    result = new int[]{b,a};
                else
                    result = new int[]{a,b};
                break;
            }
            else if(node1.val + node2.val < target)
            {
                start++;    
            }
            else
            {
                end--;
            }
        }
        return result;
    }
    public class Node
    {
        public int index;
        public int val;
        public Node(int index, int val)
        {
            this.index = index;
            this.val = val;
        }
    }
}