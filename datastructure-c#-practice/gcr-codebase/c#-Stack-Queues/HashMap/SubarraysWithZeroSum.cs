class ZeroSumSubarray
{
    public static bool Exists(int[] arr)
    {
        int[] sumArr = new int[arr.Length];
        int size = 0, sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum == 0) return true;

            for (int j = 0; j < size; j++)
                if (sumArr[j] == sum)
                    return true;

            sumArr[size++] = sum;
        }
        return false;
    }
}
