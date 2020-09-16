using Cadastro.DAL;
using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Views
{
    class ListarCliente
    {
        public static void Renderizar()
        {

            foreach (Cliente cliente in ClienteDAO.Listar())
            {
                Console.WriteLine(cliente);
            }

        }

    }
}
