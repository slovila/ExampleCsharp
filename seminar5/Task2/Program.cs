/* Задача 1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GenerateArray(int length = 12, int min = -9, int max = 9)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1); // (]
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int[] newArray = GenerateArray();
PrintArray(newArray);


void ChangeZnak(int[] array)
{
    for (int i = 0; i < array.Length; i++)

    {
        array[i] = array[i]*-1;
        
    }
    return array[];
}
 

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] GenerateArray(int length = 12, int min = -9, int max = 9)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1); // (]
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}
bool Find(int[] array1, int digit)
{

    int count = 0;
    while (count < array1.Length)
    {
        if (array1[count] == digit)
        {
            return true;
        }

        count++;

    }
    return false;
}


int[] array = GenerateArray();

int digit = -3;


PrintArray(array);
if (Find(array, digit))
{
    Console.WriteLine(" такая цифра есть");
}
else
{
    Console.WriteLine(" такой цифры нет");
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
*/

// Задача 3: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

/*int[] GenerateArray(int length = 10, int min = 10, int max = 1001)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1); // (]
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int[] array = GenerateArray();
int qnt = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 99)
    {
        qnt++;
    }
}
PrintArray(array);
Console.WriteLine(qnt);
*/

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

int[] GenerateArray(int length = 10, int min = 1, int max = 5)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int[] array = GenerateArray();
int[] Result = new int[array.Length / 2 + array.Length % 2];
PrintArray(array);
for (int i = 0, j = array.Length - 1; i <= j; i++, j--)
{
    Result[i] = array[i] * array[j];

}
PrintArray(Result);