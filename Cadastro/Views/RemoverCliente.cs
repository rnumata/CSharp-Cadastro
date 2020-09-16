using Cadastro.DAL;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Views
{
    class RemoverCliente
    {
        public static void Renderizar()
        {
            Console.WriteLine("Informe o Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Confirma exclusão? S/N");
            String res = (Console.ReadLine()).ToLower();
            if (res.Equals("s"))
            {
                Cliente c = ClienteDAO.BuscarPorid(id);
                ClienteDAO.Remover(c);
                Console.WriteLine("\nExcluido !");
            }
            
        }

    }
}
