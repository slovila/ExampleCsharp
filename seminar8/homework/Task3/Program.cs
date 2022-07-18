//Задача 3: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.


int m = Prompt("Введите число строк 1-й матрицы: ");
int n = Prompt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = Prompt("Введите число столбцов 2-й матрицы: ");
int[,] Matrix1 = GenerateArray(m,n,0,5);
Console.WriteLine($"\nПервая матрица:");
PrintArray(Matrix1);

int[,] Matrix2 = GenerateArray(n,p,0,5);
Console.WriteLine($"\nВторая матрица:");
PrintArray(Matrix2);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(Matrix1, Matrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}