static void staircase(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j < n - i - 1)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine("");
    }
}