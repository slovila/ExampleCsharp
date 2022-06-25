/*Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление*/


Console.Write("Введите первое число > ");
int namberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число > ");
int namberB = Convert.ToInt32(Console.ReadLine());

if(namberB % namberA == 0) Console.WriteLine(namberB + " кратно " + namberA);

else 
Console.WriteLine(namberB + "  не кратно " + namberA + ", так как остаток от деления равен: " + namberB % namberA);
