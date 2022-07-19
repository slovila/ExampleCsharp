//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int FuncAck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FuncAck(m - 1, 1);
  else return FuncAck(m - 1, FuncAck(m, n - 1));
}

int m = Prompt("Введите число M > ");
int n = Prompt("Введите число N > ");
int result = FuncAck(m, n);
System.Console.WriteLine($"Значение функции Аккермана равно : {result} ");
