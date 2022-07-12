int CalcSumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sum += array[i]; 
    }
    return sum;
}
