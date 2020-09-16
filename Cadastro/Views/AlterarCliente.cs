using Cadastro.DAL;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Views
{
    class AlterarCliente
    {

        public static void Renderizar()
        {

            Console.WriteLine("informe Id do cliente: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Cliente c = ClienteDAO.BuscarPorid(id);

            if (c != null)
            {
                Console.WriteLine(c);
                Console.WriteLine("Informe novo email: ");
                c.email = Console.ReadLine();
                ClienteDAO.Alterar(c);
                Console.WriteLine($"Cliente {c.nome} alterado !!");
            } else
            {
                Console.WriteLine("Cliente NAO cadastrado !");
            }
            

        }

    }
}
