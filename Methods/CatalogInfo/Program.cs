
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int j = 0; j < files.Length; j++)
    {
        System.Console.WriteLine($"{files[j].Name}");
    }
}
string path = "/Users/alekseynikitenko/Desktop/GB/Examples/ExampleCsharp/seminar9";
CatalogInfo(path);