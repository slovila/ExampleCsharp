/* 1. Напишите программу, которая принимает
на вход трёхзначное число и на выходе
показывает последнюю цифру этого числа.*/

// Код написан для числа с любым количеством знаков .

Console.Write("Enter the number > ");

string number = Console.ReadLine();

string[] arrow = { number };

Console.Write("The last digit of this number: " + arrow[0][number.Length - 1]);


