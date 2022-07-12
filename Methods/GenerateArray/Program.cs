int[] GenerateArray(int length, int min, int max)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max+1);
    }
    return newArray;
}
