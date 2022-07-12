/*
Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/
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

int CalcSumNegative(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        sum += array[i]; 
    }
    return sum;
}

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

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}; ");
    }
}

int[] array = GenerateArray(12, -9, 9);
PrintArray(array);
System.Console.WriteLine($"Сумма положительных элементов равна {CalcSumPositive(array)}, а сумма отрицательных равна {CalcSumNegative(array)}");



// sign -1 для отрицательных, 1 для положительных
/*int CalcSum(int[] array, int sign)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * sign > 0)
        sum += array[i]; 
    }
    return sum;
}
*/
