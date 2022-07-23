/*Задача 4: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой
последовательности до N-го значения, желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" (N = равно количество выводимых элементов)*/
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
void PrintDigits(int n, int count, int max)
{
    if (count > max)
    {
        return;
    }
    for (int i = 1; i <= n; i++)
    {
        count++;
        if (count > max)
        {
            return;
        }
        Console.Write($"{n} , ");
    }
    PrintDigits(n + 1, count, max);
}
int n = Prompt("Введите число");
int count = 0;
int max = n;
PrintDigits(1, count, max);
Console.WriteLine();
