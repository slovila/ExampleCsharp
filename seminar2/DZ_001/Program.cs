/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/

Console.Write("Введите трехзначное число > ");
//string[] arrow = {Console.ReadLine()};
//Console.Write("Вторая цифра этого числа: " + arrow[0][1]);
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 10;
int b1 = b % 10;
Console.WriteLine(b1);

