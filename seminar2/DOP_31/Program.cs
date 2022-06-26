
Console.WriteLine("Введите пять чисел > ");
int[] a = new int[5];
int i = 0;
double sum = 0.0;
for (i = 0; i < 5; ++i)
  {  a[i] = Convert.ToInt32(Console.ReadLine());
    sum = sum + a[i];
  }
Console.WriteLine(sum);
double arithmeticMean = sum/5.0;
Console.WriteLine(arithmeticMean);


/*string number = Convert.ToString(new Random().Next(10000, 99999));
string[] arrow = { number };
Console.WriteLine(arrow[0]);
var a = arrow[0].Length;
int count = 0;
var sum = 0.0;
double am = 0.0;
while (count < a)
{
    sum = (sum - '0') + arrow[0][count];
    count++;
}
am = sum / a;
Console.WriteLine(sum);
Console.WriteLine(am);
*/
