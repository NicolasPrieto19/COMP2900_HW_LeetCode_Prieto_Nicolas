using System;
using System.Collections.Generic;

public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        // guardamos los jewels en un HashSet para busqueda rapida
        HashSet<char> jewelSet = new HashSet<char>();

        foreach (char j in jewels)
        {
            jewelSet.Add(j);
        }

        int count = 0;

        // recorremos todas las stones
        foreach (char s in stones)
        {
            // detecta si la stone esta contenida en jewels
            if (jewelSet.Contains(s))
            {
                count++;
            }
        }

        return count;
    }
    class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        string jewels1 = "aA";
        string stones1 = "aAAbbbb";

        Console.WriteLine(sol.NumJewelsInStones(jewels1, stones1)); 
    
        string jewels2 = "z";
        string stones2 = "ZZ";

        Console.WriteLine(sol.NumJewelsInStones(jewels2, stones2)); 
    }
}
}