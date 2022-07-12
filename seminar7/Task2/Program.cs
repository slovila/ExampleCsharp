//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int [,] GenDobMass (int m, int n )
{
    int[,] Array  = new int[m,n];
    for( int i =0; i < Array.GetLength(0); i++)
    {
        for( int j =0; j < Array.GetLength(1); j++)
         {
            Array[i,j]= i+j;

         }
    }
            return Array;
}

