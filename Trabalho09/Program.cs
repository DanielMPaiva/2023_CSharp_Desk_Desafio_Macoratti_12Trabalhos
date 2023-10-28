// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using Trabalho09;

string opcaousuario = "";
bool exibemenssagemfinal = false;
int numerogeral = 0;
Auxiliar aux = new Auxiliar();

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("=============================================");
    Console.WriteLine("PROGRAMA PARÂMETRO POR VALOR E POR REFERÊNCIA");
    Console.WriteLine("=============================================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");


    //inicio programa ******************************************************************************************
    Console.Write("Insira um número inteiro: "); string valor = Console.ReadLine();
    Console.WriteLine("");
    int numerointeiro = 0;
    if (int.TryParse(valor, out numerointeiro))
    {
        numerogeral = numerointeiro;
                
        Console.WriteLine("Valor  de referencia           : " + numerogeral);
        aux.ParametroPorValor(numerogeral);
        Console.WriteLine("Passagem de parametro por valor: " + numerogeral);

        Console.WriteLine("");

        Console.WriteLine("Valor de referencia                 : " + numerogeral);
        aux.ParametroPorReferencia(ref numerogeral);
        Console.WriteLine("Passagem de parametro por referencia: " + numerogeral);

        exibemenssagemfinal = true;
    }
    else
    {
        Console.WriteLine("VALOR INVÁLIDO"); Console.ReadLine();
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
