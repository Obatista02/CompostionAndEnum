using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

string path = @"C:\Users\Guilherme Batista\OneDrive\Documentos\arquivos";


try
{

    {
       var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
        Console.WriteLine("FOLDERS: ");

        foreach (string folderItem in folder)
        {
            Console.WriteLine(folderItem);
        }
        Console.WriteLine();
        
        var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
        Console.WriteLine("Files: ");

        foreach (string folderItem in files)
        {
            Console.WriteLine(folderItem);
        }


        Console.WriteLine();

        Directory.CreateDirectory(path + "\\newFolder");
    }

}catch(IOException e)
{
    Console.WriteLine(e.Message);
}
