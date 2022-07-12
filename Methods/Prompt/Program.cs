int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}