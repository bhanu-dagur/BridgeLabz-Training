/*
Leetcode 234 (Plaindrome)
Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

Example 1:
Input: head = [1,2,2,1]
Output: true
*/
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
    public bool IsPalindrome(ListNode head) {
        ListNode slow=head;
        ListNode fast=head;
        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode reverse=Reverse(slow);
        fast=head;
        while(reverse!=null){
            if(reverse.val!=fast.val){
                return false;
            }
            fast=fast.next;
            reverse=reverse.next;
            
        }
        return true;
    }
    public ListNode Reverse(ListNode node){
        ListNode temp=node;
        ListNode pre=null;
        while(node!=null){
            temp=node.next;
            node.next=pre;
            pre=node;
            node=temp;
        }
        return pre;
    }
}