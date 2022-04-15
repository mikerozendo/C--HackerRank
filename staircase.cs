//https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true

using System;

class Result
{
    public static void staircase(int n)
    {
        string printer = string.Empty.PadLeft(n ,'#');
        string spaces = string.Empty.PadLeft(n ,' ');
        int counter = n;

        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(string.Concat(spaces.Substring(j, counter - 1), printer.Substring(counter - 1)));
            counter--;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
