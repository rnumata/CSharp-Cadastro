using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro.Models
{
    /*
     * : DbContext herança desta classe que está no EntityFramework
     * Com ela é possível mapear as classes que vão virar tabela no BD, implementar o metodo para a string de conexão e 
     * utilizar os métodos relacionados ao BD (CRUD)
     * Linha 21 é a string de conexão
     */

    class Context : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ClienteDb;Trusted_Connection=true");
        }

    }
}
