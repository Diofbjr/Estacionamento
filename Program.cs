using Estacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var estacionamento = new Estacionamento.Models.Estacionamento(precoInicial: 5.0m, precoPorHora: 2.0m);

string opcao = string.Empty;

while (opcao != "4")
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE ESTACIONAMENTO ===");
    Console.WriteLine("1 - Adicionar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("\nEscolha uma opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Digite a placa do veículo: ");
            estacionamento.AdicionarVeiculo(Console.ReadLine().ToUpper());
            break;

        case "2":
            Console.Write("Digite a placa do veículo a remover: ");
            estacionamento.RemoverVeiculo(Console.ReadLine().ToUpper());
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida, tente novamente.");
            break;
    }

    if (opcao != "4")
    {
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
}
