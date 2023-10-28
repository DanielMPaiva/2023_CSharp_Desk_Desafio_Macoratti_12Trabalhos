// See https://aka.ms/new-console-template for more information
string opcaousuario = "";
bool exibemenssagemfinal = false;

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("============================");
    Console.WriteLine("PROGRAMA SOMA DOS CARACTERES");
    Console.WriteLine("============================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");


    //inicio programa ******************************************************************************************
    Console.Write("Entre com um numero inteiro: "); string entradausuario = Console.ReadLine();
    Console.WriteLine("");
    int soma = 0;
    int valordigitado = 0;
    if (int.TryParse(entradausuario, out valordigitado))
    {
        Console.Write("Soma de ");
        for (int n = 0; n < valordigitado.ToString().Length; n++)
        {
            soma = soma + int.Parse(valordigitado.ToString().Substring(n, 1));

            if (n + 1 == valordigitado.ToString().Length)
            { Console.Write(valordigitado.ToString().Substring(n, 1)); }
            else
            { Console.Write(valordigitado.ToString().Substring(n, 1) + "+"); }
            
        }
        Console.Write(": " + soma.ToString());
        exibemenssagemfinal = true;
    }
    else
    {
        Console.WriteLine("VALOR INVÁLIDO");
        Console.ReadLine();
    }
    

    //menu final do programa **********************************************************************************
    if (exibemenssagemfinal)
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("<ENTER> para continuar ou <S> para sair");
        opcaousuario = "";
        opcaousuario = Console.ReadLine();
        if (opcaousuario.ToUpper() == "S")
        { loop = 501; }
    }
}
