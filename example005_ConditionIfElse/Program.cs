﻿Console.Write("Введите свое имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.Write("Ура! Это же Маша!");
}

else
{
    Console.Write("Привет: ");
    Console.Write(username);
}