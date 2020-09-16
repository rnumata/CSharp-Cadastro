using Cadastro.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Views
{
    class BuscarClientePorId
    {

        public static void Renderizar()
        {

            Console.WriteLine("Informe o Id do cliente");
            int c = Convert.ToInt32(Console.ReadLine()); 
            
            if(ClienteDAO.BuscarPorid(c) != null)
            {
                Console.WriteLine(ClienteDAO.BuscarPorid(c));
            } else
            {
                Console.WriteLine("Cliente NAO cadastrado");
            }

        }

    }
}
