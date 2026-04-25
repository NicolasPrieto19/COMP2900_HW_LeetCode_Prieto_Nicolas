using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int value)
    {
        val = value;
        left = null;
        right = null;
    }
}

public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        // usamos una cola para hacer una busqueda de amplitud
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int leftmost = root.val;

        // mientras haya nodos en la cola
        while (queue.Count > 0)
        {
            int size = queue.Count;

            // se recorre un nivel completo
            for (int i = 0; i < size; i++)
            {
                TreeNode current = queue.Dequeue();

                // el primer nodo del nivel es el mas a la izquierda
                if (i == 0)
                {
                    leftmost = current.val;
                }

                // agregamos hijos a la cola
                if (current.left != null)
                {
                    queue.Enqueue(current.left); // se agrega hijo izquierdo al siguiente nivel
                }

                if (current.right != null)
                {
                    queue.Enqueue(current.right); // se agrega hijo derecho al siguiente nivel
                }
            }
        }

        return leftmost;
    }
    class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        TreeNode root = new TreeNode(1);

        root.left = new TreeNode(2);
        root.right = new TreeNode(3);

        root.left.left = new TreeNode(4);

        root.right.left = new TreeNode(5);
        root.right.right = new TreeNode(6);

        int result = sol.FindBottomLeftValue(root);

        Console.WriteLine("Resultado:");
        Console.WriteLine(result); 
        

        TreeNode root2 = new TreeNode(1);
        root2.left = new TreeNode(2);

        Console.WriteLine(sol.FindBottomLeftValue(root2));

    }
}
}