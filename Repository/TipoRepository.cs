using ProjetoTfoq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Repository
{
    
    //Instacia a classe Conexão Criando a Conexão com o banco  - 3° Passo
    public class TipoRepository
    {
        Contexto banco = new Contexto();
        //Retorna Todas os Tipos
        public List<Tipo> GetAll()
        {
            return banco.Tipo.ToList();
        }
        //REtorna Apenas um tipo
        public Tipo Get(int id)
        {
            return banco.Tipo.Find(id);
        }
        //Cadastra o Tipo
        public void AddTipo(Tipo tipo)
        {
            banco.Tipo.Add(tipo);
            banco.SaveChanges();
        }

        //Modifica o Tipo
        public void UpdateTipo(Tipo tipo)
        {
            banco.Entry<Tipo>(tipo).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();
        }

        //Deleta o Tipo
        public void DeleteTipo(int id)
        {
            Tipo tipo = Get(id);
            banco.Tipo.Remove(tipo);
            banco.SaveChanges();       
        }
    }
}