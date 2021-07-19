using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    [Table("Mantimento")]
    public class Mantimento
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Validade { get; set; }
        public int Capacidade { get; set; }

        public int ConteudoAtual { get; set; }
       // [NotMapped]
        public decimal Precentual => (Convert.ToDecimal(ConteudoAtual) / Convert.ToDecimal(Capacidade)) * 100;

        public int TipoId { get; set; }
        public int TipoNome { get; set; }
        public Tipo Tipo { get; set; }

    }
}