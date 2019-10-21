// Complete the miniMaxSum function below.
static void miniMaxSum(int[] arr)
{
    long totalSum = 0;
    long min = arr[0];
    long max = arr[0];
    long maxSum = 0;
    long minSum = 0;
    long[] data = new long[3];
    for (int i = 0; i < arr.Length; i++)
    {
        totalSum += arr[i];
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
        data[0] = min;
        data[1] = max;
        data[2] = totalSum;

    }

    maxSum = data[2] - data[0];
    minSum = data[2] - data[1];
    Console.WriteLine("{0} {1}", minSum, maxSum);


}