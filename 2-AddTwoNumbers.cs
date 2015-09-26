/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 public class Solution {
 	public ListNode AddTwoNumbers (ListNode l1, ListNode l2)
 	{
 		var addin = 0;
 		ListNode result = new ListNode(addin);
 		ListNode start = result;
 		while(l1 != null || l2 != null){
 			var addout = getval (l1) + getval (l2) + addin;
 			if (addout >= 10) {
 				addin = addout / 10;
 				addout = addout % 10;
 			} else {
 				addin = 0;
 			}
 			start.val = addout;
 			
 			if (l1 != null)
 			l1 = l1.next;
 			if (l2 != null)
 			l2 = l2.next;
 			if(l1==null&&l2==null&&addin==0){
 				start.next = null;
 			}else{
 				start.next = new ListNode(addin);
 			}
 			start = start.next;
 			
 		}
 		return result;
 	}

 	public int getval (ListNode node)
 	{
 		if (node == null)
 		return 0;
 		return node.val;
 	}
 }