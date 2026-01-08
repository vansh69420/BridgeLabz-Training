class LongestConsecutive
{
    public static int Find(int[] arr)
    {
        int max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int curr = arr[i];
            int count = 1;

            while (Contains(arr, curr + 1))
            {
                curr++;
                count++;
            }
            if (count > max) max = count;
        }
        return max;
    }

    static bool Contains(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == x) return true;
        return false;
    }
}
