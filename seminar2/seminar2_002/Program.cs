//2. Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.

int Max(int arg1, int arg2) // метод нахождения максимального числа
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

string[] arrow = {Convert.ToString(new Random().Next(10, 99))};

char firstNumber = (arrow[0][0]); // разделяем полученное число на символы
char secondNumber = (arrow[0][1]);

int fn = Convert.ToInt32(firstNumber); // получаем значение первой цифры в кодировке ASCII
int sn = Convert.ToInt32(secondNumber);// получаем значение второй цифры в кодировке ASCII
int max = Max(fn, sn); // применяем метод нахождения максимального числа
char maxNumber = Convert.ToChar(max);// получаем символ из ASCII

Console.WriteLine("Random number > " + arrow[0]);

Console.WriteLine("Maximal digit of random number: " + maxNumber);

