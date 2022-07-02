//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Вводи числа с приглашением
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

// Вычисление суммы цифр числа
int CalcSumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("Введите число > ");
int result = CalcSumDigits(number);
System.Console.WriteLine($"Сумма цифр равна {result}");



/* Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

//Ввод числа с приглашением
int Promt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int count = 0;
while (number > 0)
{
    number = number /10;
    count++;
}
System.Console.WriteLine(count);



/* Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

//Ввод числа с приглашением
int Promt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int mult = 1;
int i = 1;
while (i <= number)
{
    mult = mult * i;
    i++;
}
System.Console.WriteLine(mult);



* Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
int RandomNum(int min, int max)
{
    int a = new Random().Next(min, max + 1);
    return a;
}

int[] NewArray(int length, int min, int max)
{
    int[] arr = new int[length];
    int i = 0;
    while (i < length)
    {
        arr[i] = RandomNum(min, max);
        i++;
    }
    return arr;
}

void Print(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}

int[] array1 = NewArray(8, 0, 1);
Print(array1);





/* 1 2 3 8 6
1 * 6 + 2 * 8 + 3 * 3 */

int Promt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int NumberSymb(int number)
{
    int c = 0;
    while (number > 0)
    {
        number = number / 10;
        c++;
    }
    return c;
}
int numberSymbols = NumberSymb(number);
int sum = 0;

int HighSymbol = (int)Math.Pow(10, numberSymbols - 1);
int temp = number;
int count = 1;
while (temp > 0)
{
    sum = sum + (temp / HighSymbol) * (temp % 10);
    System.Console.WriteLine("Первый символ " + temp / HighSymbol);
    System.Console.WriteLine("Последний символ " + temp % 10);
    System.Console.WriteLine("Сумма внутри цикла " + sum);
    temp = temp % HighSymbol / 10;
    System.Console.WriteLine(temp);
    HighSymbol = HighSymbol / 100;
    System.Console.WriteLine("Номер итерации" + count);
    count++;

}


System.Console.WriteLine(sum);



/* Сумма четных цифр числа */

int Promt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int sum = 0;

int temp = number;

int count = 1;
while (temp > 0)
{
    if ((temp % 10) % 2 == 0) sum = sum + temp % 10;
    temp = temp / 10;

    count++;

}

System.Console.WriteLine(sum);




/* Вводим строку вручную затем убираем пробелы */

string Promt(string msg)
{
    System.Console.WriteLine(msg);
    string text = Console.ReadLine();
    return text;
}

string RemoveSpaces(string text)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != ' ')
        {
            result = result + text[i];
        }
    }
    return result;
}
string newtext = RemoveSpaces(Promt("Введите текст: "));
System.Console.WriteLine(newtext);

bool IfPalindrome(string newtext)
{
    int i = newtext.Length - 1;
    int j = 0;

    while (i > j)
    {
        if (newtext[i] != newtext[j])
        {
            return false;
        }
        i--;
        j++;
    }
    return true;
}

if (!IfPalindrome(newtext)) System.Console.WriteLine("Фраза не является палиндромом!");
else System.Console.WriteLine("Фраза является палиндромом!");