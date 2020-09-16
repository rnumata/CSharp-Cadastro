using Cadastro.DAL;
using Cadastro.Models;
using System;


namespace Cadastro.Views
{
    class CadastrarCliente
    {

        public static void Renderizar()
        {

            Cliente c = new Cliente();

            Console.WriteLine("Informe nome: ");
            c.nome = Console.ReadLine();
            Console.WriteLine("Informe email: ");
            c.email = Console.ReadLine();

            if (ClienteDAO.Cadastrar(c))
            {
                Console.WriteLine(c);
                Console.WriteLine("\nCadastrado com sucesso !!");
                c = new Cliente();
            } else
            {
                Console.WriteLine("\nCadastro NAO efetuado. Email já cadastrado !");
            }
            

        }






    }
}
