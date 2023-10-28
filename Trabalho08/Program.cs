// See https://aka.ms/new-console-template for more information
using System.Collections;

string usuariovalor1 = "";
string usuariovalor2 = "";
int valor1 = 0;
int valor2 = 0;
string opcaousuario = "";
bool exibemenssagemfinal = false;

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine("PROGRAMA NÚMERO PRIMO");
    Console.WriteLine("=====================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");

    Console.WriteLine("Favor entre com dois valores que serão comparados entre si e será mostrado o maior e se ele é um número primo.");
    Console.WriteLine(" ");
    Console.Write("Entre com o valor 1: ");
    usuariovalor1 = Console.ReadLine();

    if (usuariovalor1 != "")
    {
        if (int.TryParse(usuariovalor1, out valor1))
        {            
            Console.Write("Entre com um valor 2: ");
            usuariovalor2 = Console.ReadLine();

            if (int.TryParse(usuariovalor2, out valor2))
            {
                Console.WriteLine(" ");

                if (valor1 > valor2)
                { Console.WriteLine("MAIOR: " + valor1); }
                else if (valor2 > valor1)
                { Console.WriteLine("MAIOR: " + valor2); }
                else
                { Console.WriteLine("SÃO IGUAIS"); }

                bool eprimo = true;
                for (int n = valor1-1; n > 1; n--)
                { 
                    if (valor1 % n == 0)
                    {
                        eprimo = false;
                    }
                }
                if (eprimo)
                { Console.WriteLine(valor1.ToString() + " É PRIMO"); }
                else
                { Console.WriteLine(valor1.ToString() + " NÃO É PRIMO"); }

                eprimo = true;
                for (int n = valor2 - 1; n > 1; n--)
                {
                    if (valor2 % n == 0)
                    {
                        eprimo = false;
                    }
                }
                if (eprimo)
                { Console.WriteLine(valor2.ToString() + " É PRIMO"); }
                else
                { Console.WriteLine(valor2.ToString() + " NÃO É PRIMO"); }

                exibemenssagemfinal = true;
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("VALOR INVÁLIDO");
                Console.ReadLine();
                exibemenssagemfinal = false;
            }
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("VALOR INVÁLIDO");
            Console.ReadLine();
            exibemenssagemfinal = false;
        }
    }

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
