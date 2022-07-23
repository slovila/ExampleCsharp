/*Задача 3: Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.
При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). Разрешена только рекурсия и целочисленная арифметика.*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
void PrintDigit (int n)
{
    if (n==0)
    {
        return;
    }
    Console.WriteLine($"{n%10}");
    PrintDigit(n/10);
}
int n =Prompt("Введите число");
Console.WriteLine();
PrintDigit(n);
