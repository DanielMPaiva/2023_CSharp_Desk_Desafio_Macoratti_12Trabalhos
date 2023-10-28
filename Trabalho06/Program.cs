// See https://aka.ms/new-console-template for more information
using System;

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("=============================");
    Console.WriteLine("PROGRAMA CONVERSOR DE MEDIDAS");
    Console.WriteLine("=============================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");


    Console.WriteLine("Selecione o tipo de conversão:");
    Console.WriteLine("");
    Console.WriteLine("P - Polegadas para Centímetros");
    Console.WriteLine("G - Galão para Litros");
    Console.WriteLine("M - Milhas para Kilometros");

    string opusuario;

    Console.Write("> "); 
    opusuario = Console.ReadLine();

    switch (opusuario.ToUpper())
    {
        case "P":
            Console.WriteLine(" ");
            Console.WriteLine("Informe as polegadas: ");
            string polegadas = Console.ReadLine();
            decimal valorpolegadas = 0;
            if (decimal.TryParse(polegadas, out valorpolegadas))
            {
                Console.WriteLine(" ");
                Console.WriteLine("> " + (valorpolegadas * (decimal)2.54).ToString() + " centímetro(s)");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("VALOR INVÁLIDO");
            }
            break;

        case "G":
            Console.WriteLine(" ");
            Console.WriteLine("Informe os galões: ");
            string galoes = Console.ReadLine();
            decimal valorgaloes = 0;
            if (decimal.TryParse(galoes, out valorgaloes))
            {
                Console.WriteLine(" ");
                Console.WriteLine("> " + (valorgaloes * (decimal)3.78541178).ToString() + " litro(s)");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("VALOR INVÁLIDO");
            }
            break;

        case "M":
            Console.WriteLine(" ");
            Console.WriteLine("Informe as milhas: ");
            string milhas = Console.ReadLine();
            decimal valormilhas = 0;
            if (decimal.TryParse(milhas, out valormilhas))
            {
                Console.WriteLine(" ");
                Console.WriteLine("> " + (valormilhas * (decimal)1.609344).ToString() + " quilometro(s)");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("VALOR INVÁLIDO");
            }
            break;

        default:
            Console.WriteLine(" ");
            Console.WriteLine("OPÇÃO INVÁLIDA");
            break;
    }

    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("<ENTER> para continuar <S> para sair");
    string opcaousuario = Console.ReadLine();
    if (opcaousuario == "S" || opcaousuario == "s")
    { loop = 501; }
}
