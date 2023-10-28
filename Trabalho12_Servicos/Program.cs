// See https://aka.ms/new-console-template for more information
using System.ServiceProcess;

string opcaousuario = "";
bool exibemenssagemfinal = false;



for (int loop = 0; loop <= 500; loop++)
{
    Console.Clear();
    Console.WriteLine("==========================");
    Console.WriteLine("PROGRAMA LISTA DE SERVIÇOS");
    Console.WriteLine("==========================");
    Console.WriteLine(" ");
    Console.WriteLine(" ");


    //inicio programa ******************************************************************************************
    ServiceController[] services = ServiceController.GetServices();
    Console.WriteLine("Exibindo os serviços do Windows Instaldos");

    foreach (ServiceController servico in services)
    {
        Console.WriteLine(" Serviço : " + servico.DisplayName);
    }
    Console.WriteLine("\n\n");
    Console.WriteLine(" Total de Serviços : " + services.Count());
    exibemenssagemfinal = true;

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
