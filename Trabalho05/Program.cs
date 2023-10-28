// See https://aka.ms/new-console-template for more information
for (int loop = 0; loop <= 500; loop++)
{
    bool erro = false;

    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("PROGRAMA SOMA SÉRIE FINITA");
    Console.WriteLine("==========================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Informe o intervalor de valores a exibir para série");
    Console.WriteLine("n1*^x + 2*x^2 + 3*x^3 + 4*x^4 + 5*x^5 + … + n*x^n");
    Console.Write("> ");
    string valor = Console.ReadLine();
    int numero = 0;
    double soma = 0;
    double x;
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    if (int.TryParse(valor, out numero))
    {
        for (int i = 1; i <= numero; i++)
        {
            Console.Write(i + "*x^" + i);
            if (i < numero)
                Console.Write(" + ");
            x = (double)i;
            soma = soma + (i * Math.Pow(x, x));
        }
        Console.WriteLine(" ");
        Console.WriteLine("Total da série: " + (long)soma);
    }
    else
    { Console.WriteLine("VALOR INVÁLIDO"); erro = true; }



    if (!erro)
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("<ENTER> para continuar <S> para sair");
    }

    string opcaousuario = Console.ReadLine();
    if (opcaousuario == "S" || opcaousuario == "s")
    { loop = 501; }
}
