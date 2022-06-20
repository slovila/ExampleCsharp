/*Задача 4: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.*/
Console.WriteLine("Enter the number > ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine("All even numbers in the range from 1 to N : ");
while(count <= number)
{
    if (count % 2 == 0)
    Console.WriteLine(count);
    count=count+2;

}
