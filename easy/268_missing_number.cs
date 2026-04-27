using System;

// algoritmo que soluciona el problema
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;

        // se recorre cada numero 

        for (int i = 0; i <= n; i++)
        {
            bool found = false;

            // verificamos si el numero se encuentra dentro la posicion del arreglo

            for (int j = 0; j < n; j++)
            {
                if (nums[j] == i)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return i;
            }
        }

        return -1;
    }
}

// prueba para verificar el funcionamiento de la solucion
class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] nums1 = { 3, 0, 1 };
        int[] nums2 = { 0, 1, 2, 3, 4, 6 };
        int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

        Console.WriteLine(sol.MissingNumber(nums1));
        Console.WriteLine(sol.MissingNumber(nums2));
        Console.WriteLine(sol.MissingNumber(nums3));
    }
}