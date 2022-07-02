/* Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.*/
/*string[] arrow = {Console.ReadLine()};
if(arrow[0].Length >= 3) Console.Write("Третья цифра заданного числа : " + arrow[0][2]);
else
Console.Write("Третья цифра в заданном числе отсутствует!");


Console.Write("Введите трехзначное число > ");
int a = Convert.ToInt32(Console.ReadLine());

if (a/100 <1)Console.Write("Третья цифра в заданном числе отсутствует!");
else
{
Console.Write("Третья цифра заданного числа : " + a%10);
}
*/

System.Console.WriteLine("Введите целое число => ");
long number = Math.Abs(long.Parse(Console.ReadLine()));

long result = number;

if (number < 100)
{
    System.Console.WriteLine("В заданном числе нет третьей цифры!");
}
else
{
    long count = number;
    while (count > 999)
    {
        count = count / 10;
    }
    result = count % 10;
    System.Console.WriteLine($"Третья цифра заданного числа => {result}");
}