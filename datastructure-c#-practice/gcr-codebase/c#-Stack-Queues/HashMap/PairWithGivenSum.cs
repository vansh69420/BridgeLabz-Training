class PairSum
{
    public static bool FindPair(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] + arr[j] == target)
                    return true;

        return false;
    }
}
