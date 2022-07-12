/* Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]


int[] GenerateArray(int length, int min, int max)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max+1);
    }
    return newArray;
}

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        System.Console.WriteLine($"{array[i]}; ");
    }
}
nt[] GenerateArray(int length = 10, int min = 1, int max = 5)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1); 
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

void ChangeEl( int[] array)
{
    int i = 0;
    int j = array.Length -1;
    while( i < array.Length/2)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }

}

int [] array = GenerateArray();
PrintArray(array);
ChangeEl(array);
PrintArray(array);

*/

//Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

void  CheckTriangle()

{System.Console.Write("Введите первое число > ");
int firstSide = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число > ");
int secondSide = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите третье число > ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

if (firstSide >= secondSide + thirdSide || secondSide >= firstSide + thirdSide || thirdSide >= firstSide + secondSide)
{
    System.Console.WriteLine("Треугольник с заданными длинами сторон не возможен!");
}
else
    System.Console.WriteLine("Треугольник с заданными длинами сторон существует");
}

CheckTriangle();

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int A = Promt ( "enter A ");
int B = Promt ("enter B ");
int C = Promt ("enter C ");

//int summA = A + B;
//int summB = 
if (A > B + C || B > A + C || C > B + A) 
{
    Console.WriteLine("такой треугольник не существует");
}
else Console.WriteLine(" такой треугольник существует");
