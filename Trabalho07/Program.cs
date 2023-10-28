// See https://aka.ms/new-console-template for more information
using System;
int[] arrayprincipal = new int[0];
string valordigitado = "";
int valordigitadointeiro = 0;
string opcaousuario = "";
int menorvalorpraordenar = 0;
int[] arrayauxiliar = new int[0];
int[] arrayordenado = new int[0];
List<int> listarray = new List<int>();

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("========================");
    Console.WriteLine("PROGRAMA ORGANIZAR ARRAY");
    Console.WriteLine("========================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    //exibe array original
    Console.Write("Array Original: { ");
    if (arrayprincipal.Length > 0)
    {
        for (int n = 0; n < arrayprincipal.Length; n++)
        { Console.Write(arrayprincipal[n].ToString() + " "); }
    }
    Console.Write("}");

    Console.WriteLine("");

    //exibe array ordenado
    if (arrayprincipal.Length > 1)
    {
        Array.Sort(arrayprincipal);

        Console.Write("Array Ordenado: { ");
        if (arrayprincipal.Length > 0)
        {
            for (int n = 0; n < arrayprincipal.Length; n++)
            { Console.Write(arrayprincipal[n].ToString() + " "); }
        }
        Console.Write("}");
    }

    

    Console.WriteLine(" ");
    Console.Write("Entre com um valor: ");
    valordigitado = Console.ReadLine();

    if (valordigitado == "")
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("<ENTER> para continuar, <N>Novo Array ou <S> para sair");
        opcaousuario = "";
        opcaousuario = Console.ReadLine();
        if (opcaousuario.ToUpper() == "S")
        { loop = 501; }
        else if (opcaousuario.ToUpper() == "N")
        { listarray.Clear(); Array.Clear(arrayprincipal); arrayprincipal = new int[0]; }
    }
    else
    {
        if (int.TryParse(valordigitado, out valordigitadointeiro))
        {
            listarray.Add(valordigitadointeiro);
            Array.Clear(arrayprincipal);
            arrayprincipal = listarray.ToArray();

        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("VALOR INVÁLIDO");
            Console.ReadLine();
        }
    }


    


    


    
}
