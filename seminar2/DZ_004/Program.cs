/* Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

Console.Write("Введите номер дня недели > ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 7 || number == 6) Console.WriteLine("Этот день недели является выходным днем.");
else 
if(number < 1 || number > 7) Console.WriteLine("Этот день недели не существует."); 
else
Console.WriteLine("Этот день недели  не является выходным днем.");


