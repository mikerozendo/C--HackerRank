//https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

class Result
{
    public static void plusMinus(List<int> arr)
    {
        List<decimal> decimals = new List<decimal>();
        int zeros = 0;
        int positives = 0;
        int negatives = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < 0)
                negatives++;
            else if (arr[i] > 0)
                positives++;
            else
                zeros++;
        }

        decimals.Add((decimal) positives / arr.Count);
        decimals.Add((decimal) negatives / arr.Count);
        decimals.Add((decimal) zeros / arr.Count);
        
        foreach (decimal value in decimals)
            Console.WriteLine(value.ToString("F6", CultureInfo.InvariantCulture));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.plusMinus(arr);
    }
}
