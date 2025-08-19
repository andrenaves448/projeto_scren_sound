// Screen Sound                
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{

    //fsymbols.com
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    //Console.WriteLine("**************************************************************************");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu() 
{
    Console.WriteLine("\nDigite 1 para registrar uma banca");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida= Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) 
    {
        case 1: RegistrarBanda();
            break;
        case 2: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3:
            Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("\nAté logo!! " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("\nOpção inválida. Por favor, tente novamente.");
            break;
    }
}

void RegistrarBanda() 
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); // Pausa de 2 segundos para o usuário ler a mensagem
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
