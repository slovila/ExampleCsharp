int[] CopyArray ( int[] array)
{
    int[]array2 = new int [array.Length];
    for( int i =0; i < array2.Length;i++)
    {
        array2[i] = array[i];
    }
    return array2;
}