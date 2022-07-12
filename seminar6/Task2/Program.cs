//Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//string BinaryCode = Convert.ToString(56, 2);
//System.Console.WriteLine(BinaryCode);

//1. Разделить целое десятичное число на 2, остаток записать.
//2. Если полученное частное не меньше 2, то продолжать деление.
//3. Двоичный код десятичного числа при последовательной записи последнего частного и всех остатков, начиная с последнего.


int[] ConvertToBeenary(int number)
{
    int[]array = new int [10];
    int i = 0;
    while(number > 0)
    {
      array[i] = number%2;
      number = number / 2;
      i++; 
    }
    return array;
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

int[]array = ConvertToBeenary(10);
ChangeEl(array);
PrintArray(array);
