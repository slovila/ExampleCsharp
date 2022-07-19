//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все чётные натуральные числа в промежутке 
//от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
void PrintNaturalDigits(int n, int m)
{
    if (n < m)
    {
        System.Console.WriteLine(" ");
        return;
    }
    
    PrintNaturalDigits(n - 1, m);
    if (n % 2 == 0)
    {
        System.Console.Write($" {n} ");
    }

}
int n = 10;
int m = 0;
System.Console.WriteLine($"Все четные числа от {m} до {n} : ");
PrintNaturalDigits(n, m);