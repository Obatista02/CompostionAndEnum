using System;


SortedSet<int> a = new SortedSet<int>(){ 0,2,3,4,5,6, 9,10};
SortedSet<int> b = new SortedSet<int>() { 0, 22, 33, 514, 125, 62, 19, 10 };

//uniao em forma ordenada e sem repetir

SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

//intersection, separa os numeros que se repetem

SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
PrintCollection(d);

//diferrence

SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
PrintCollection(e);



static void PrintCollection<Generic>(IEnumerable<Generic> collection)
{
    foreach (Generic item in collection)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();

}