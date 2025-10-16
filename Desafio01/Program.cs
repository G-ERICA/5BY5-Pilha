
using Desafio01;

int option;

Pilha pilha = new Pilha();

do
{
    Console.WriteLine("------------ Pilha de Roupas -----------");
    Console.WriteLine("Escolha o que deseja fazer: " +
        "\n1 - Inserir Roupa" +
        "\n2 - Remover Roupa" +
        "\n3 - Mostrar Pilha" +
        "\n4 - Sair");

    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.WriteLine("Qual peça esta cadastrando?");
            string descricao = (Console.ReadLine()!);
            Console.WriteLine("Qual a cor da roupa?");
            string cor = (Console.ReadLine()!);

            Roupa roupa = new Roupa(descricao, cor);

            pilha.InserirPUSH(roupa);
            Console.Clear();
            break;
        case 2:
            Console.WriteLine("----- Removendo último item adicionado -----");
            pilha.RemoverPOP();
            Console.Clear();
            break;
        case 3:
            pilha.ImprimirPilha();
            break;
        default:
            while (option < 1 && option > 4)
            {
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Escolha o que deseja fazer: " +
                "\n1 - Inserir Roupa" +
                "\n2 - Remover Roupa" +
                "\n3 - Mostrar Pilha" +
                "\n4 - Sair");
            }
            break;

    }

} while (option != 4);



