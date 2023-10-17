using System;

Dictionary<string, string> cookies = new Dictionary<string, string>();

try { 
cookies["User"] = "Maria";
cookies["email"] = "Maria@gmail.com";
cookies["phone"] = "997722558";
cookies["phone"] = "911111111";

Console.WriteLine(cookies["phone"]);
Console.WriteLine(cookies["email"]);

cookies.Remove("email");


    Console.WriteLine("Size: " + cookies.Count);
    Console.WriteLine("ALL Cookies: ");
    foreach (KeyValuePair<string, string> item in cookies)
    {
        Console.WriteLine(item.Key + ": "+ item.Value);
    }

}
catch( KeyNotFoundException e)
{
    Console.WriteLine("There is not key");
}