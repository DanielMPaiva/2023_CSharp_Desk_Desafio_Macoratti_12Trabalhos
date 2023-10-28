// See https://aka.ms/new-console-template for more information
for (int n = 1; n <= 7; n++)
{
    if (n == 1 || n == 7)
    { Console.WriteLine("*"); }
    else if (n == 2 || n == 6)
    { Console.WriteLine("**"); }
    else if (n == 3 || n == 5)
    { Console.WriteLine("***"); }
    else if (n == 4)
    { Console.WriteLine("****"); }
    else
    { }
}

Console.ReadLine();