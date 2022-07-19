//Задача 2: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N 
//с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
void PrintSum(int n, int m, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        System.Console.Write($"Сумма всех чисел от M до N : {sum}  ");
        return;
    }
    
    PrintSum(n - 1, m, sum);
   
}

int n = 8;
int m = 4;
int sum = 0;
PrintSum(n, m, sum);
