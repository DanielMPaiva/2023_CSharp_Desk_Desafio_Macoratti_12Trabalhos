// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Globalization;
using System.Text;

string opcao = null;

for (int n = 1; n < 500; n++)
{
    Console.Clear();
    Console.WriteLine("n." + n.ToString());
    Console.WriteLine("====================== ");
    Console.WriteLine("PROGGRAMA TABELA ASCII");
    Console.WriteLine("====================== ");
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Selecione a opção:");
    Console.WriteLine(" ");
    Console.WriteLine("1 - Para digitar um carcatere e ver o código ASCII em Decimal e Hexadecimal");
    Console.WriteLine("2 - Para digitar um código ASCII em Decimal e ver o caracatere");
    Console.WriteLine("3 - Para digitar um código ASCII em Hexadecimal e ver o caracatere");
    Console.WriteLine("S - Para Sair");
    Console.WriteLine(" ");
    

    if (opcao is null)
    {   
        Console.Write("> ");
        opcao = Console.ReadLine();
    }
    else
    {   
        Console.WriteLine(">"+opcao);
    }


    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "S" && opcao != "s")
    {
        Console.WriteLine(" ");
        Console.WriteLine("OPÇÃO INVÁLIDA");
        Console.ReadLine();
        opcao = null;
    }
    else if (opcao == "S" || opcao == "s")
    {
        n = 501;
    }
    else
    {
        if (opcao == "1")
        {
            Console.WriteLine(" ");
            Console.Write("Digite um caratere: ");
            string caract = Console.ReadLine();
            if (caract != "")
            {
                Console.WriteLine("Valor Decimal do carcatere '" + caract.Substring(0, 1) + "'    : " + ((byte)Char.Parse(caract.Substring(0, 1))).ToString());
                Console.WriteLine("Valor Hexadecimal do carcatere '" + caract.Substring(0, 1) + "': " + BitConverter.ToString(Encoding.Default.GetBytes(caract.Substring(0, 1))));

                int valordecimal = int.Parse(((byte)Char.Parse(caract.Substring(0, 1))).ToString());
                string tipo = "";
                if (valordecimal >= 48 && valordecimal <= 57)
                { tipo = "NÚMERO"; }
                else if (valordecimal >= 65 && valordecimal <= 90)
                { tipo = "LETRA MAIÚSCULA"; }
                else if (valordecimal >= 97 && valordecimal <= 122)
                { tipo = "LETRA MINÚSCULA"; }
                else
                { tipo = "SÍMBOLO ESPECIAL"; }
                Console.WriteLine("Tipo do carcatere: " + tipo);
            }
        }
        else if (opcao == "2")
        {
            Console.WriteLine(" ");
            Console.Write("Digite um valor Decimal: ");
            string caract = Console.ReadLine();

            if (caract != "" && caract != null)
            {
                int resultado;

                if (int.TryParse(caract, out resultado))
                {
                    if (resultado >= 0 && resultado <= 255)
                    {
                        Console.WriteLine("Caracatere correspondente: " + Convert.ToChar(resultado).ToString());
                    }
                    else
                    { Console.WriteLine("VALOR INVÁLIDO"); }
                }
                else
                { Console.WriteLine("VALOR INVÁLIDO"); }
            }
        }
        else if (opcao == "3")
        {
            Console.WriteLine(" ");
            Console.Write("Digite um valor Hexadecimal: ");
            string caract = Console.ReadLine();

            if (caract != "" && caract != null)
            {
                int resultado;

                if (int.TryParse(caract, System.Globalization.NumberStyles.HexNumber, CultureInfo.CurrentCulture, out resultado))
                {
                    if (resultado >= 0 && resultado <= 255)
                    {
                        Console.WriteLine("Caracatere correspondente: " + Convert.ToChar(resultado).ToString());
                    }
                    else
                    { Console.WriteLine("VALOR INVÁLIDO"); }
                }
                else
                { Console.WriteLine("VALOR INVÁLIDO"); }
            }
        }

            Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("ENTER para continuar ou  S para voltar");
        string opuser = Console.ReadLine();
        if (opuser == "S" || opuser == "s")
        { opcao = null; }
    }
}