/*Задача 5: Заполните спирально квадратный массив по возрастанию, с заданным размером*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] matrix)
{
    int number = 1;
    int FirstRow = 0;
    int FirstColumn = 0;
    int LastRow = matrix.GetLength(0);
    int LastColumn = matrix.GetLength(1);
    while (number <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (int j = FirstColumn; j < LastColumn; j++)
        {
            matrix[FirstRow, j] = number;
            number++;
        }
        for (int k = FirstRow + 1; k < LastRow; k++)
        {
            matrix[k, LastColumn - 1] = number;
            number++;
        }
        for (int i = LastColumn - 2; i >= FirstColumn; i--)
        {
            matrix[LastRow - 1, i] = number;
            number++;
        }
        for (int l = LastRow - 2; l > FirstColumn; l--)
        {
            matrix[l, FirstColumn] = number;
            number++;
        }
        FirstRow++;
        FirstColumn++;
        LastColumn--;
        LastRow--;
    }
    return matrix;
}

int[,] matrix = new int[5, 5];
matrix = FillArray(matrix);
PrintArray(matrix);
