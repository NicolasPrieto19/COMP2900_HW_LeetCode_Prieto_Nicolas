using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        List<int> result = new List<int>();

        int current = 1;

        for (int i = 0; i < n; i++)
        {
            result.Add(current);

            // Intentar ir al numero mas alto que tenga a n como primer caracter
            if (current * 10 <= n)
            {
                current = current * 10;
            }
            else
            {
                // Si el current sale de rango:

                // Evitar salirnos del rango o terminar en 9
                while (current % 10 == 9 || current + 1 > n)
                {
                    current = current / 10; 
                }

                current++; 
            }
        }

        return result;
    }
    class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int n1 = 13;
        var result1 = sol.LexicalOrder(n1);

        Console.WriteLine("Resultado para n = 13:");
        PrintList(result1);

        int n2 = 25;
        var result2 = sol.LexicalOrder(n2);

        Console.WriteLine("Resultado para n = 25:");
        PrintList(result2);
    }
    static void PrintList(IList<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
}