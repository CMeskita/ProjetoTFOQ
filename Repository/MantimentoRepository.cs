using ProjetoTfoq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    public class MantimentoRepository
    {
        Contexto banco = new Contexto();

        public List<Mantimento> GetAll()
        {
            return banco.Mantimento.ToList();
        }

        public Mantimento Get(int id)
        {
            return banco.Mantimento.Find(id);
        }

        public void Add(Mantimento mantimento)
        {
            banco.Mantimento.Add(mantimento);
            banco.SaveChanges();
        }


        public void Update(Mantimento mantimento)
        {
            banco.Entry<Mantimento>(mantimento).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }


        public void Delete(int id)
        {
            Mantimento mantimento = Get(id);
            banco.Mantimento.Remove(mantimento);
            banco.SaveChanges();
        }
    }
}