/*4. Напишите программу, которая принимает на вход
число и проверяет, кратно ли оно одновременно 7 и
23.*/

Console.Write("Введите число > ");
int namber = Convert.ToInt32(Console.ReadLine());
if((namber % 7 == 0) ||(namber % 23 == 0) ) Console.WriteLine(namber + " кратно и 7 и 23 " );

else 
    Console.WriteLine(namber + " не кратно и 7 и 23 одновременно ! " );

