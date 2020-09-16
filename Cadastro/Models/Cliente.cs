using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadastro.Models
{

    [Table("Clientes")]
    class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public String nome { get; set; }
        public String email { get; set; }
        public DateTime Criadoem { get; set; }


        public Cliente()
        {
            Criadoem = DateTime.Now;
        }


        public override string ToString()
        {
            return $"id: {ClienteId}|\tNome: {nome}|\temail: {email}|Criado em: {Criadoem}";
        }


    }
}
