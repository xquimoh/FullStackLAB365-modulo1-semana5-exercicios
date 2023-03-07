using System.Globalization;
using Banco;

IClienteServices clienteService = new ClienteServices();

string opcao;
do
{
    Console.WriteLine("Bem-vind@ ao Banco Fullstack!\nEscolha uma opção:");
    Console.WriteLine("1 - Criar conta ");
    Console.WriteLine("2 - Adicionar transacao");
    Console.WriteLine("3 - Consultar extrato");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("5 - Exibir clientes");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        clienteService.CriarConta();
    }
    else if (opcao == "5")
    {
        clienteService.ExibirClientes();
    }
    else if (opcao == "2")
    {
        AdicionarTransacao();
    }
    else if (opcao == "3")
    {
        ExibirExtrato();
    }

    Console.WriteLine("Tecle Enter para continuar");
    Console.ReadLine();
} while (opcao != "4");


void AdicionarTransacao()
{
    Cliente contaCliente = clienteService.BuscarCliente();

    if (contaCliente == null)
    {
        Console.WriteLine("Conta não cadastrada, por favor, cadastre antes");
        return;
    }

    Console.WriteLine("Digite o valor da transação");
    double valor = double.Parse(Console.ReadLine());
    Transacao transacao = new Transacao(DateTime.Now, valor);

    contaCliente.Extrato.Add(transacao);
}

void ExibirExtrato()
{
    Cliente contaCliente = clienteService.BuscarCliente();

    if (contaCliente == null)
    {
        Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
        return;
    }

    double saldo = 0;
    foreach (Transacao transacao in contaCliente.Extrato)
    {
        Console.WriteLine("Data: " + transacao.Data + " Valor: " +
                          transacao.Valor.ToString("C2", new CultureInfo("pt-BR")));
        saldo += transacao.Valor;
    }

    Console.WriteLine("Saldo = " + contaCliente.Saldo);
}