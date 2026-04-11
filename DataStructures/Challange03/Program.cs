using System;
using System.Collections.Generic;
using System.Linq;

void Rotacionar(int[] nums, int k)
{
    int n = nums.Length;
    k %= n; // lidar com k maior que n
    Array.Reverse(nums, 0, n);
    Array.Reverse(nums, 0, k);
    Array.Reverse(nums, k, n - k);
}

Console.WriteLine("Array Rotation Test:");
int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;
Console.WriteLine("Original: " + string.Join(", ", nums));
Rotacionar(nums, k);
Console.WriteLine("Rotated by " + k + ": " + string.Join(", ", nums));