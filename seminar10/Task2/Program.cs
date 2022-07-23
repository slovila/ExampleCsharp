/*Задача 2: Напишите программу, которая на вход принимает два числа и
выдаёт первые N чисел, для которых каждое следующее равно сумме двух
предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
void FibaVar(int m, int n, int N)
{
    int sum = 0;
    if (N == 0)
    {
        return;
    }
    sum = n + m;
    Console.WriteLine($"{m}");
    FibaVar(n, sum, N - 1);
}
int m = Prompt("Введите первое число");
int n = Prompt("Введите второе число");
int N = Prompt("Введите количество чисел");
FibaVar(m, n, N);
