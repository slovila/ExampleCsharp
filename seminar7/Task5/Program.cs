// Задайте двумерный массив. Введите элемент, 
//и найдите первое его вхождение, выведите позиции по горизонтали 
//и вертикали, или напишите, что такого элемента нет.
//Например, такой массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Введенный элемент 2, результат: [1, 4]

//Введенный элемент 6, результат: такого элемента нет.
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

void FindEll( int[,]array, int A) // нам надо добавить эллимент для поиска
{
    bool isFind = false;

for(int i = 0; i < array.GetLength(0);i++ )
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        if (array[i,j] == A )
        {
            isFind = true;
            Console.WriteLine($"{i+1},{j+1}");
            //return;
        }  
    }
    if(!isFind)
    {
     Console.WriteLine(" нет такого элемента ");
     }   
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
int A = Prompt("Введите искомое число  > ");

FindEll(myArray, A);

/*
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

bool FindExist(int[,,] array, int find)
{
    foreach (int n in array)
    {
        if (n == find)
        {
            return true;
        }
    }
    return false;
}

void PrintThreeDimensionArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Слой {i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}\t");
            }
            System.Console.WriteLine();
        }

    }
    System.Console.WriteLine();
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите количество столбцов > ");
int lines = Prompt("Введите количество рядов > ");
int[,,] matrix = GenerateThreeDimensionArray(rows, columns, lines, 1, 999);
PrintThreeDimensionArray(matrix);
*/