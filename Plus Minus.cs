static void plusMinus(int[] arr)
{
    double positive = 0;
    double negative = 0;
    double zero = 0;
    double[] temp = new double[3];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positive++;
        }
        else if (arr[i] < 0)
        {
            negative++;
        }
        else
        {
            zero++;
        }

        temp[0] = (positive / arr.Length);
        temp[1] = (negative / arr.Length);
        temp[2] = (zero / arr.Length);

    }

    Console.WriteLine("{0:N6}", temp[0]);
    Console.WriteLine("{0:N6}", temp[1]);
    Console.WriteLine("{0:N6}", temp[2]);

}