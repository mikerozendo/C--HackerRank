//https://www.hackerrank.com/challenges/tutorial-intro/problem?isFullScreen=true

int V = Convert.ToInt32(Console.ReadLine().Trim());
int n = Convert.ToInt32(Console.ReadLine().Trim());
List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = Result.IntroTurorial(V, arr);

Console.WriteLine(result);

class Result
{
    public static int IntroTurorial(int V, List<int> arr)
    {
        return arr.IndexOf(V);
    }
}
