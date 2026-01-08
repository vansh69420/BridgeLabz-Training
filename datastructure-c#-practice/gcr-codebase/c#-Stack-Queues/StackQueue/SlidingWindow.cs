class SlidingWindow
{
    public static void MaxWindow(int[] arr, int k)
    {
        int[] dq = new int[arr.Length];
        int front = 0, rear = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (front <= rear && dq[front] <= i - k)
                front++;

            while (front <= rear && arr[dq[rear]] <= arr[i])
                rear--;

            dq[++rear] = i;

            if (i >= k - 1)
                Console.Write(arr[dq[front]] + " ");
        }
    }
}
