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
    public int CountNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftHeight = GetLeftHeight(root);
        int rightHeight = GetRightHeight(root);

        // Si las alturas son iguales es un arbol perfecto
        if (leftHeight == rightHeight)
        {
            //Representacion de la formula 2^h - 1 que sirve para calcular si un arbol es perfecto.
            return (int)Math.Pow(2, leftHeight) - 1;
        }

        // Cuando un arbol no es perfecto, contamos el nodo actual, mas la suma de los nodos a la izquiera y de la derecha
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    private int GetLeftHeight(TreeNode node)
    {
        int height = 0;

        while (node != null)
        {
            height++;
            node = node.left;
        }

        return height;
    }

    private int GetRightHeight(TreeNode node)
    {
        int height = 0;

        while (node != null)
        {
            height++;
            node = node.right;
        }

        return height;
    }

    class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(2);
        TreeNode node3 = new TreeNode(3);
        TreeNode node4 = new TreeNode(4);
        TreeNode node5 = new TreeNode(5);
        TreeNode node6 = new TreeNode(6);

        root.left = node2;
        root.right = node3;

        node2.left = node4;
        node2.right = node5;

        node3.left = node6;

        Solution sol = new Solution();

        Console.WriteLine(sol.CountNodes(root)); 
    }
}
}