class CircularTour
{
    public static int FindStart(int[] petrol, int[] dist)
    {
        int balance = 0, deficit = 0, start = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            balance += petrol[i] - dist[i];

            if (balance < 0)
            {
                deficit += balance;
                start = i + 1;
                balance = 0;
            }
        }
        return (balance + deficit >= 0) ? start : -1;
    }
}
