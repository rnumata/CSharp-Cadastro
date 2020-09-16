using System;

namespace Cadastro.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecao;

            do
            {
                Console.Clear();
                Console.WriteLine("-- Selecione Menu --");
                Console.WriteLine("1- Cadastrar");
                Console.WriteLine("2- Listar");
                Console.WriteLine("3- Buscar por Id");
                Console.WriteLine("4- Buscar por email");
                Console.WriteLine("5- Remover");
                Console.WriteLine("6- Alterar");
                Console.WriteLine("0- Sair");
                selecao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (selecao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarCliente.Renderizar();
                        break;
                    case 3:
                        BuscarClientePorId.Renderizar();
                        break;
                    case 4:
                        BuscarClientePorEmail.Renderizar();
                        break;
                    case 5:
                        RemoverCliente.Renderizar();
                        break;
                    case 6:
                        AlterarCliente.Renderizar();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla...");
                Console.ReadKey();
            } while (selecao != 0);
        }
    }
}
