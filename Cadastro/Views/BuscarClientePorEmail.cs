using Cadastro.DAL;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Views
{
    class BuscarClientePorEmail
    {

        public static void Renderizar()
        {
            Console.WriteLine("Informe o email: ");
            String email = Console.ReadLine();
            Cliente c = ClienteDAO.BuscarPorEmail(email);
            if (c != null)
            {
                Console.WriteLine(c);
            } else
            {
                Console.WriteLine("\nEmail NAO cadastrado !");
            }
            
            
            //try
            //{
            //    Console.WriteLine(ClienteDAO.BuscarPorEmailUnico(email));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("\n" + e.Message);
            //}
        }

    }
}
