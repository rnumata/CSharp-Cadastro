using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro.DAL
{
    class ClienteDAO
    {

        private static Context _context = new Context();
        
        
        /// <summary>
        /// Metodo que recebe um objeto da view, faz a verificacao se já existe e cadastra no BD
        /// </summary>
        /// <param name="c"></param>
        /// <returns>true ou false</returns>
        public static bool Cadastrar(Cliente c)
        {
            if (BuscarPorEmail(c.email) == null)
            {
                _context.clientes.Add(c);
                _context.SaveChanges();
                return true;
            }
            return false;    
        }


        /// <summary>
        /// Metodo que usa arrow function e gera uma lista de todos os objetos
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public static List<Cliente> Listar() => _context.clientes.ToList();


        /// <summary>
        /// Returns the first element of a collection, or the first element that satisfies a condition. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Returns null if index is out of range</returns>
        public static Cliente BuscarPorEmail(String email) => _context.clientes.FirstOrDefault(x => x.email.Equals(email));


        /// <summary>
        /// Searches for an element that matches the conditions defined by the specified predicate,
        /// and returns the first occurrence within the entire List<T>.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>obj Cliente</returns>
        public static Cliente BuscarPorid(int id) => _context.clientes.Find(id);


        /// <summary>
        /// The same as Single, except that it returns a default value of a specified generic type, 
        /// instead of throwing an exception if no element found for the specified condition. However, 
        /// it will thrown InvalidOperationException if it found more than one element for the specified condition in the collection.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>        
        public static Cliente BuscarPorEmailUnico(String email)
        {
            try
            {
                return _context.clientes.SingleOrDefault(x => x.email.Equals(email));
            }
            catch (Exception)
            {
                throw new Exception("Existe mais de um email cadastrado !");
            }
        }


        /// <summary>
        /// Metodo com Lambda e clausula where e contains.
        /// </summary>
        /// <param name="parteNome"></param>
        /// <returns> Um List de clientes que contem o parteNome. Se nao achar retorna uma List VAZIA</returns>
        public static List<Cliente> FiltrarPorPartedoNome(String parteNome) => _context.clientes.Where(x => x.nome.Contains(parteNome)).ToList();




        public static void Alterar(Cliente cliente)
        {
            _context.clientes.Update(cliente);
            _context.SaveChanges();
        }



        public static void Remover(Cliente cliente)
        {
            _context.clientes.Remove(cliente);
            _context.SaveChanges();
        }



    }
}
