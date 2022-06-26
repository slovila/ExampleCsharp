System.Console.WriteLine("Введите номер четверти ");
int quarter = int.Parse(Console.ReadLine());

/* if(quarter == 1)
{
    System.Console.WriteLine("В четверти 1 X>0 и Y>0");
}
if(quarter == 2)
{
    System.Console.WriteLine("В четверти 2 X<0 и Y>0");
}
if(quarter == 3)
{
    System.Console.WriteLine("В четверти 3 X<0 и Y<0");
}
if(quarter == 4)
{
    System.Console.WriteLine("В четверти 4 X>0 и Y<0");
} */

switch (quarter)
{
    case 1:
        System.Console.WriteLine("В четверти 1 X>0 и Y>0");
        break;
    case 2:
        System.Console.WriteLine("В четверти 2 X<0 и Y>0");
        break;
    case 3:
        System.Console.WriteLine("В четверти 3 X<0 и Y<0");
        break;
    case 4:
        System.Console.WriteLine("В четверти 4 X>0 и Y<0");
        break;
    case > 4:
        System.Console.WriteLine("Удоли");
        break;
}
