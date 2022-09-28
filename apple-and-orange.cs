//https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true

var housePoints = Helper.SplitHelper();
int houseStartPoinint = housePoints[0];
int houseEndPoint = housePoints[1];

var treesPoints = Helper.SplitHelper();
int appleTreePoint = treesPoints[0];
int orangeTreePoint = treesPoints[1];

var fruitCounts = Helper.SplitHelper();
List<int> appleValues = Helper.SplitHelper();
List<int> orangeValues = Helper.SplitHelper();

Result.CountApplesAndOranges(houseStartPoinint, houseEndPoint, appleTreePoint, orangeTreePoint, appleValues, orangeValues);

class Result
{
    public static void CountApplesAndOranges(int houseStartPoint, int houseEndPoint, int appleTreePoint, int orangeTreePoint, List<int> appleValues, List<int> oragenValues)
    {
        int appleFallenInHouseCount = 0;
        int orangeFallenInHouseCount = 0;

        foreach (int appleDistanceFall in appleValues)
        {
            appleFallenInHouseCount = ValidateDistance(appleDistanceFall, appleTreePoint, houseStartPoint, houseEndPoint, appleFallenInHouseCount);
        }

        foreach (int oragenDistanceFall in oragenValues)
        {
            orangeFallenInHouseCount = ValidateDistance(oragenDistanceFall, orangeTreePoint, houseStartPoint, houseEndPoint, orangeFallenInHouseCount);
        }

        Console.WriteLine(appleFallenInHouseCount);
        Console.WriteLine(orangeFallenInHouseCount);
    }

    private static int ValidateDistance(int distance1, int distance2, int houseStartPoint, int houseEndPoint, int controller)
    {
        int fallDistance = distance1 + distance2;

        if (fallDistance >= houseStartPoint && fallDistance <= houseEndPoint)
            controller++;

        return controller;
    }
}

static class Helper
{
    public static List<int> SplitHelper()
    {
        return Console.ReadLine()
                        .TrimEnd()
                        .Split(' ')
                        .Select(x => Convert.ToInt32(x))
                        .ToList();
    }
}
