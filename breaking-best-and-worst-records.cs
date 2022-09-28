//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true

int.TryParse(Console.ReadLine().Trim(), out int lines);

List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

List<int> result = Result.breakingRecords(scores);

Console.WriteLine(String.Join(" ", result));

static class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        return new()
        {
            scores.GetHighestOrLowestBreakCount(false,true),
            scores.GetHighestOrLowestBreakCount(true, false)
        };
    }

    static int GetHighestOrLowestBreakCount(this List<int> scores, bool lowest, bool highest)
    {
        int breakCount = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            var helper = scores.Take(i).Distinct().ToList();

            if (!helper.Any() || helper.Contains(scores[i])) continue;

            breakCount = ValidateBreakCount(lowest, highest, breakCount, helper, scores[i]);
        }

        return breakCount;
    }

    static int ValidateBreakCount(bool lowest,
        bool highest,
        int breakCount,
        List<int> scoresHelper,
        int actualScore)
    {
        if (highest)
        {
            if (actualScore > scoresHelper.Max()) breakCount++;
        }
        else if (lowest)
        {
            if (actualScore < scoresHelper.Min()) breakCount++;
        }

        return breakCount;
    }
}

