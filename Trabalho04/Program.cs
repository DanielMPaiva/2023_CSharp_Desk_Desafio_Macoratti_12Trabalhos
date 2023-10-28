// See https://aka.ms/new-console-template for more information

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("PROGRAMA MATRIZ IDENTIDADE");
    Console.WriteLine("==========================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.Write("Digite o tamanho da Matriz (número 2 ou maior): ");
    string n;
    n = Console.ReadLine();
    int m;
    Console.WriteLine(" ");
    bool erro = false;
    
    if (int.TryParse(n, out m))
    {
        if (m >= 2)
        {
            //int posiçãolinha = 1;
            //int posiçãocoluna = 1;

            for (int linha = 1; linha <= m; linha++)
            {
                for (int coluna = 1; coluna <= m; coluna++)
                {
                    if (/*posiçãolinha == linha && posiçãocoluna == coluna*/ linha==coluna)
                    { Console.Write("1 "); /*posiçãolinha++; posiçãocoluna++;*/ }
                    else
                    { Console.Write("0 ");  }
                }
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("FAVOR INSIRA VALOR DE 2 OU MAIOR");
            erro = true;
        }
    }
    else
    {
        Console.WriteLine("VALOR INVÁLIDO");
        erro = true;
    }

    if (!erro)
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("<ENTER> para continuar <S> para sair");
    }
    
    string opcaousuario = Console.ReadLine();
    if(opcaousuario == "S" || opcaousuario == "s")
    { loop = 501; }
}


