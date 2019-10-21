static int diagonalDifference(int[][] arr)
{
    int LtR = 0;
    int RtL = 0;
    int absValue = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            if (i == j)
            {
                LtR += arr[i][i];
            }
            if (j == arr.Length - i - 1)
            {
                RtL += arr[i][j];
            }
        }
        absValue = Math.Abs(LtR - RtL);

    }
    return absValue;

}