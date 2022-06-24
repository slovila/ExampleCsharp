/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.*/


/*string str = Convert.ToString(new Random().Next(100, 999));
Console.WriteLine(str);
int[] arr = str.Select(x => x - '0').ToArray();
Console.WriteLine(arr[0]);
int a = arr[0];
int b = arr[2];
int modifyNumber = a * 10 + b;
Console.WriteLine(modifyNumber); */



string[] arrow = { Convert.ToString(new Random().Next(100, 999)) };

Console.WriteLine(arrow);
Console.WriteLine("Random number is > " + arrow[0]);
int result = (Convert.ToInt32(arrow[0][0]) - '0') * 10 + (Convert.ToInt32(arrow[0][2]) - '0');
Console.Write("Modify number is: " + result);

/*int number = (Convert.ToInt32(new Random().Next(100, 999)));
Console.WriteLine(number);
int a = number / 10, b = number % 10;
int c = a / 10, d = a % 10;
int result = c * 10 + b;
Console.Write(result);*/
