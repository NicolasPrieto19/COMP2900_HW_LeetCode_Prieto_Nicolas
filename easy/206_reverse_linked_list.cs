using System;

// Definicion del nodo de la lista
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int value)
    {
        val = value;
        next = null;
    }
}

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Crear lista
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);

        Console.WriteLine("Lista original:");
        PrintList(head);

        Solution sol = new Solution();

        // Revertir la lista
        ListNode reversed = sol.ReverseList(head);

        Console.WriteLine("Lista invertida:");
        PrintList(reversed);
    }

    // Metodo para imprimir la lista
    static void PrintList(ListNode head)
    {
        ListNode current = head;

        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }

        Console.WriteLine("null");
    }
}