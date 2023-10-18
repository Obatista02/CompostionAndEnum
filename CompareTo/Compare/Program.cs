﻿using System.Collections.Generic;
using Nelio.entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 900));
list.Add(new Product("Notebook", 1200));
list.Add(new Product("Tablet", 450));

//Expressao Lambda
//pode colocar a expressao direta no metodo Sort
//Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort(CompareProducts);

foreach (Product item in list)
{
    Console.WriteLine(item);
}

static int CompareProducts(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}