/* Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.*/
/*string[] arrow = {Console.ReadLine()};
if(arrow[0].Length >= 3) Console.Write("Третья цифра заданного числа : " + arrow[0][2]);
else
Console.Write("Третья цифра в заданном числе отсутствует!");
*/

Console.Write("Введите трехзначное число > ");
int a = Convert.ToInt32(Console.ReadLine());

if (a/100 <1)Console.Write("Третья цифра в заданном числе отсутствует!");
else
{
Console.Write("Третья цифра заданного числа : " + a%10);
}
