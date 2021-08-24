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

       [Column("marca",TypeName ="varchar")]
       [MaxLength(100)]
        public string Marca { get; set; }
        [Column("validade")]
        public DateTime Validade { get; set; }
        [Column("capacidade")]
        public int Capacidade { get; set; }

        [Column("conteudo")]
        public int Conteudo { get; set; }
        // [NotMapped]
        public decimal Precentual => (Convert.ToDecimal(Conteudo) / Convert.ToDecimal(Capacidade)) * 100;

        public int TipoId { get; set; }
        public virtual Tipo Tipo { get; set; }

    }
}