// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using  Estaciona.Models;

decimal precoInicial=0;
decimal precoPorHora=0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
//Console.WriteLine("Digite o preço inicial:");

do
{
    Console.Write("Digite o preço inicial:(R$) ");
} while (!decimal.TryParse(Console.ReadLine(), out precoInicial));

do
{
    Console.Write("Digite o preço por hora: (R$) ");
} while (!decimal.TryParse(Console.ReadLine(), out precoPorHora));

//precoInicial = Convert.ToDecimal(Console.ReadLine());

//Console.WriteLine("Agora digite o preço por hora:");
//precoPorHora = Convert.ToDecimal(Console.ReadLine());
 Estacionamentos automovel= new Estacionamentos(precoInicial,precoPorHora);



bool exibirMenu = true;

while(exibirMenu)
{
    
    Console.WriteLine("OPÇÃO 1- ESTACIONAR VEICULO");
    Console.WriteLine("OPÇÃO 2- LISTAR VEICULOS");
    Console.WriteLine("OPÇÃO 3- ENCERRAR ESTACIONAMENTO DO VEICULO");
    Console.WriteLine("OPÇÃO 4- SAIR ");

Console.WriteLine("Digite a opção Desejada:");

string opcao =Console.ReadLine();
 switch (opcao)
 {
    case ("1"):
    automovel.AdicionarVeiculo();
    break;
   

    case("2"):
    automovel.ListarVeiculos();
    break;

    case ("3"):
    automovel.RemoverVeiculo();
    break;

    case ("4"):
    exibirMenu = false;
    break;

    default:
    Console.WriteLine("Opção inválida");
    break;

    // Console.WriteLine("Pressione uma tecla para continuar");
    // Console.ReadLine();

 }

}


Console.WriteLine("O programa se encerrou");
