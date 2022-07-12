int[,,] GenerateThreeDimensionArray(int rows, int columns, int lines, int min, int max)
{
    int[,,] array = new int[rows, columns, lines];
    Random rnd = new Random();
    int temp = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < lines; k++)
            {
                do
                {
                    temp = rnd.Next(min, max + 1);
                } while (FindExist(array, temp));
                array[i, j, k] = temp;
            }
        }
    }
    return array;
}
