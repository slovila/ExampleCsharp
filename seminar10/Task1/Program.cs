// Задача 1: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс


string alphabet = "аисв";
SearchWords(alphabet);

void SearchWords(string alphabet, int length = 4, string prefix = "")
{
    if (length == 0)
    {
        System.Console.WriteLine(prefix);
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        char ch = alphabet[i];
    // foreach (char ch in alphabet)
    
        SearchWords(alphabet, length-1, prefix + ch);
    }
}
