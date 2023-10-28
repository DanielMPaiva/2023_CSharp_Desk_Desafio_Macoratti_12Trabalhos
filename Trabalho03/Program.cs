// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

Console.WriteLine("TABELA ASCII");
Console.WriteLine(" ");
Console.WriteLine("DEC -   HEX - CARACTERE");

string valordecimal = "";
string valorhexa = "";
int n = 0;

do
{
    if (n <= 9)
    { valordecimal = "  " + n.ToString(); }
    else if (n >= 10 && n <= 99)
    { valordecimal = " " + n.ToString(); }
    else
    { valordecimal = n.ToString(); }

    valorhexa = BitConverter.ToString(Encoding.Default.GetBytes(Convert.ToChar(n).ToString()));

    if (valorhexa.Length == 1)
    { valorhexa = "    " + valorhexa.ToString(); }
    else if (valorhexa.Length == 2)
    { valorhexa = "   " + valorhexa.ToString(); }

    if (n == 10)
    { Console.WriteLine(valordecimal + " - " + valorhexa + " - New Line"); }
    else if (n == 27)
    { Console.WriteLine(valordecimal + " - " + valorhexa + " - Escape"); }
    else
    { Console.WriteLine(valordecimal + " - " + valorhexa + " - " + Convert.ToChar(n).ToString()); }

    n++;
} while (n <= 255);

Console.ReadLine();