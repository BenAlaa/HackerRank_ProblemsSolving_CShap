static int birthdayCakeCandles(int[] ar)
{
    int noOfCandlesSheCanBlow = 0;
    int maxHeight = 0;
    int[] data = new int[2];
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] > maxHeight)
        {
            maxHeight = ar[i];
            data[0] = maxHeight;
        }
    }
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == data[0])
        {
            noOfCandlesSheCanBlow++;
            data[1] = noOfCandlesSheCanBlow;
        }
    }
    return data[1];

}