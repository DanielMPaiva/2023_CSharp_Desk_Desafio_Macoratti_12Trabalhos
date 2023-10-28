// See https://aka.ms/new-console-template for more information
using System.Reflection;

string opcaousuario = "";
bool exibemenssagemfinal = false;
string entradausuario = "";
int lado1 = 0;
int lado2 = 0;
int lado3 = 0;

for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("==================================");
    Console.WriteLine("PROGRAMA CÁLCULO ÁREA DO TRIÂNGULO");
    Console.WriteLine("==================================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");


    //inicio programa ******************************************************************************************
    Console.WriteLine("Entre com os tamanhos do triângulo");
    Console.Write("Lado 1: ");
    entradausuario = Console.ReadLine();
    if (int.TryParse(entradausuario, out lado1))
    {
        Console.Write("Lado 2: ");
        entradausuario = Console.ReadLine();
        if (int.TryParse(entradausuario, out lado2))
        {
            Console.Write("Lado 3: ");
            entradausuario = Console.ReadLine();
            if (int.TryParse(entradausuario, out lado3))
            {
                /*
                VALIDAR SE É TRINAGULO
                Só irá existir um triângulo se, somente se, os seus lados obedeceram à seguinte regra:
                um de seus lados deve ser maior que o valor absoluto(módulo) da diferença dos outros dois lados 
                e menor que a soma dos outros dois lados.
                */

                if (
                    (lado1 > (lado2 - lado3) && lado1 < (lado2 + lado3)) &&
                    (lado2 > (lado1 - lado3) && lado2 < (lado1 + lado3)) &&
                    (lado3 > (lado1 - lado2) && lado3 < (lado1 + lado2))
                    )
                {
                    /*
                    CALCULAR A AREA DO TRIANGULO
                    */

                    double perimetro = lado1 + lado2 + lado3;
                    Console.WriteLine("Perimetro (l1+l2+l3)        : " + perimetro.ToString());
                    double semiperimetro = perimetro / 2;
                    Console.WriteLine("Semiperímetro p=(l1+l2+l3)/2: " + semiperimetro.ToString());
                    double preraiz = semiperimetro - lado1;
                    Console.WriteLine("p-l1                        : " + preraiz.ToString());
                    preraiz = preraiz * semiperimetro;
                    Console.WriteLine("p*(p-l1)                    : " + preraiz.ToString());
                    preraiz = preraiz * (semiperimetro - lado2);
                    Console.WriteLine("(p*(p-l1))*(p-l2)           : " + preraiz.ToString());
                    preraiz = preraiz * (semiperimetro - lado3);
                    Console.WriteLine("((p*(p-l1))*(p-l2))*(p-l3)  : " + preraiz.ToString());
                    double area = Math.Sqrt(preraiz);
                    Console.WriteLine("");
                    Console.WriteLine("ÁREA DO TRIÂNGULO           : " + area.ToString());
                    exibemenssagemfinal = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Não é possível formar um trinângulo com os valores informados");
                    Console.WriteLine("Insira novos valores");
                    exibemenssagemfinal = true;
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("VALOR INVÁLIDO");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("VALOR INVÁLIDO");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("");
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
