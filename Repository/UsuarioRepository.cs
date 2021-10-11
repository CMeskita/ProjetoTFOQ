using ProjetoTfoq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTfoq.Repository
{
    public class UsuarioRepository
    {
        Contexto banco = new Contexto();

        public List<Usuario> GetAll()
        {
            return banco.Usuario.ToList();
        }

        public Usuario Get(int id)
        {
            return banco.Usuario.Find(id);
        }

        public void Add(Usuario usuario)
        {
            banco.Usuario.Add(usuario);
            banco.SaveChanges();
        }
       
    }
}