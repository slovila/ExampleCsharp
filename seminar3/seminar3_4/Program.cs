/*Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
*/


double Promt(string message)
{
    Console.Write(message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

double x1 = Promt("Введите координату X1 точки: ");
double y1 = Promt("Введите координату Y1 точки: ");

double x2 = Promt("Введите координату X2 точки: ");
double y2 = Promt("Введите координату Y2 точки: ");

double x = x2 - x1;
double y = y2 - y1;

Console.WriteLine($"Расстояние между точками 1 и 2 равно: {Math.Sqrt(x*x + y*y)}");
