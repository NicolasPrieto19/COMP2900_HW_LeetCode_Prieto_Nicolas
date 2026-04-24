using System;
using System.Collections.Generic;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        // Diccionario para contar cuantas veces aparece cada numero
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        // Contamos ocurrencias
        foreach (int num in nums)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap[num] = 1;
            }
        }

        // Buscamos el numero que solo aparece 1 vez
        foreach (KeyValuePair<int, int> pair in countMap)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }
        return -1;
    }
    class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] nums1 = { 5, 4, 4, 1, 2, 1, 2 };
        Console.WriteLine(sol.SingleNumber(nums1)); 
        
        int[] nums2 = { 3 , 1, 2, 2, 1 };
        Console.WriteLine(sol.SingleNumber(nums2)); 
        
        int[] nums3 = { 1, 1, 1, 2 };
        Console.WriteLine(sol.SingleNumber(nums3)); 
        
    }
}
}