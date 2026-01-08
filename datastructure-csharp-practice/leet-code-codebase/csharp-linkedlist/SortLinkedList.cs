/*
Leetcode 148 (Sort Linked List)

Given the head of a linked list, return the list after sorting it in ascending order.

Example 1:
Input: head = [4,2,1,3]
Output: [1,2,3,4]
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
    public ListNode SortList(ListNode head) {
        if(head==null || head.next==null){
            return head;
        }
        ListNode mid=Middle(head);
        ListNode temp=mid.next;
        mid.next=null;
        ListNode x=SortList(head);
        ListNode y=SortList(temp);
        return Merge(x,y);
    }
    public ListNode Middle(ListNode head){
        ListNode slow=head;
        ListNode fast=head.next;

        while(fast!=null && fast.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        return slow;
    }
    public ListNode Merge(ListNode l1,ListNode l2){
        ListNode dummy=new ListNode(-1);
        ListNode curr=dummy;
        while(l1!=null && l2!=null){
            if(l1.val<l2.val){
                dummy.next=l1;
                l1=l1.next;
            }
            else{
                dummy.next=l2;
                l2=l2.next;
            }
            dummy=dummy.next;
            
            
        }
        while(l1!=null){
            dummy.next=l1;
            dummy=dummy.next;
            l1=l1.next;
        }
        while(l2!=null){
            dummy.next=l2;
            dummy=dummy.next;
            l2=l2.next;
        }

        return curr.next;
    }
}