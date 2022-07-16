//Задача 1: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ChangeArrayLine(int[,] array)
{
  for( int i = 0 ; i < array.GetLength(1); i++)
  {
     int temp = array[0 , i];

    array[0,i]=array[array.GetLength(0)-1, i];
    
    array[array.GetLength(0)-1, i] = temp;
  }
 

}

int[,]array1 = GenDobMass(3,4);
PrintArray(array1);
ChangeArrayLine(array1);
Console.WriteLine();
PrintArray(array1);