/* Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
*/
System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
    System.Console.Write(Math.Pow(count, 3) + " ");
}



/*System.Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int result = 0;

for (int count = 1; count <= N; count++)
{
    result = 1;
    int index = 1;
    while (index <= count)
        {
        result = result * count;
        index++;
        }
        System.Console.Write(result + " ");
}

int Pow(int c) function
{
    int res = 1;
    int i = 1;
    while (i <= c)
        {
        res = res * c;
        i++;
        }
    return res;
}






*/