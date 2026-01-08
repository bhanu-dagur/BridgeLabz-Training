//  Leetcode=>206 ( Reverse Linked List)
// Given the head of a singly linked list, reverse the list, and return the reversed list.

// Example 1:
// Input: head = [1,2,3,4,5]
// Output: [5,4,3,2,1]
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode temp=head;
        ListNode pre=null;
        while(head!=null){
            temp=head.next;
            head.next=pre;
            pre=head;
            head=temp;
        }
        return pre;

    }
}