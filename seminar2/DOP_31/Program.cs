
Console.WriteLine("Введите пять чисел > ");
while(a=5)
{
    
}



//string number = Convert.ToString(new Random().Next(10000, 99999));
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
