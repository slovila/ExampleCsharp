void ReverseArray( int[] array)
{
    int i = 0;
    int j = array.Length -1;
    while( i < array.Length/2)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }

}
