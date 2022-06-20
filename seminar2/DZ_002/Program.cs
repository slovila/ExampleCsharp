/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.*/

string[] arrow = {Convert.ToString(new Random().Next(100, 999))};
Console.WriteLine("Random number is > " + arrow[0]);
Console.Write("Modify number is: " + arrow[0][0] + arrow[0][2] + "  ");
/*char firstNumber = (arrow[0][0]); // разделяем полученное число на символы
char secondNumber = (arrow[0][1]);
char thirdNumber = (arrow[0][2]);
int result = Convert.ToInt32(firstNumber + thirdNumber);
char modifyNumber = Convert.ToChar(result);

//string[] newArrow = {Convert.ToString(arrow[0][0]),Convert.ToString(arrow[0][2])};
Console.WriteLine(result);*/