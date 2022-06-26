/* Напишите программу, которая выводит случайное число из отрезка [10,9999] и показывает наибольшую цифру этого числа */


string number = Convert.ToString(new Random().Next(10, 9999));
string[] arrow = { number };

Console.WriteLine("Случайное число > " + arrow[0]);
var a = arrow[0].Length;
var max = arrow[0][0];
int count = 1;

while (count < a)
{
    if (arrow[0][count] > max) max = arrow[0][count];
    count++;
}

Console.WriteLine("Максимальная цифра случайного числа > " + max);