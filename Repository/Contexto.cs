using ProjetoTfoq.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    public class Contexto : DbContext
    {
        //Faz a conexão atavez da String // banco criado com EntityFrameWor e Configurado no Web Config - 2° Passo
        public Contexto() : base("tfoqConnectionString")
        {
          
        }

        public DbSet<Tipo> Tipo { get; set; }

        public DbSet<Mantimento> Mantimento { get; set; }


    }
}