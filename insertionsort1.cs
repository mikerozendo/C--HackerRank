//https://www.hackerrank.com/challenges/insertionsort1/problem?isFullScreen=true

int n = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

Result.insertionSort1(n, arr);
class Result
{
    public static void insertionSort1(int arrayLenght, List<int> arr)
    {
        int last = arr.Last();

        for (int i = arrayLenght - 1; i <= arrayLenght - 1; i--)
        {
            if (i == 0) break;

            int nextPositionValue = arr[i - 1];

            if (nextPositionValue > last)
            {
                arr[i] = nextPositionValue;
            }
            else
            {
                arr[i] = last;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }

}
