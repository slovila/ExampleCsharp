﻿int n = 1;
void FindWords(string alphabet, char[] word, int length = 0 )
{
    if (length==word.Length)
    {
        System.Console.WriteLine($"{n++} {new string (word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length+1);
    }
}

FindWords("asdf", new char[5]);