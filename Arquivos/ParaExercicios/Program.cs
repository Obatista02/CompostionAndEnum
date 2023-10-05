using System;
using System.IO;

string Path = @"C:\Users\Guilherme Batista\OneDrive\Documentos\arquivos\file1.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(Path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
   
}
catch (IOException e)
{
    Console.WriteLine("An error accurred");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) { sr.Close();}
}