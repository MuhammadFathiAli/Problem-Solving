public static long countInversions(List<int> arr)
{
    return mergeSort(arr, 0, arr.Count - 1);
}

private static long mergeSort(List<int> arr, int left, int right)
{
    if (left >= right)
        return 0;
    int mid = (left + right) / 2;
    long invCount = 0;
    invCount += mergeSort(arr, left, mid);
    invCount += mergeSort(arr, mid + 1, right);
    invCount += mergePortion(arr, left, right);
    return invCount;
}

private static long mergePortion(List<int> arr, int left, int right)
{
    int invCount = 0;
    int mid = ((left + right) / 2) + 1;
    int i = left;
    int j = mid;
    int k = left;
    int[] temp = new int[arr.Count];
    while ((i <= mid - 1) && (j <= right))
    {
        if (arr[i] <= arr[j])
        {
            temp[k++] = arr[i++];
        }
        else
        {
            temp[k++] = arr[j++];
            invCount += (mid - i);
        }
    }
    while (i <= mid - 1)
    {
        temp[k++] = arr[i++];
    }
    while (j <= right)
    {
        temp[k++] = arr[j++];
    }
    for (int x = left; x <= right; x++)
    {
        arr[x] = temp[x];
    }
    return invCount;
}
    }