/*
Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

/*string s = Convert.ToString(Console.ReadLine());
if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром!");
else
{
Console.WriteLine("НЕ Палиндром!");
}*/


int n= Convert.ToInt32(Console.ReadLine());
int a=n;
int b=0;
while(a>0)
{
 b=b*10;
 b=b+a%10;
 a = a/10;
}
b = b+a;
if(n==b)System.Console.WriteLine(" Палиндром ");
else
{
    System.Console.WriteLine(" Не палиндром ");
}
