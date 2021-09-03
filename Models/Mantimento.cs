using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoTfoq.Models
{
    [Table("Mantimento")]
    public class Mantimento
    {
        [Key]
        public int Id { get; set; }

        [Column("marca", TypeName = "varchar")]
        [MaxLength(100)]
        public string Marca { get; set; }
        [Column("validade")]
        public string Validade { get; set; }
        [Column("capacidade")]
        public int Capacidade { get; set; }

        [Column("conteudo")]
        public int Conteudo { get; set; }
        // [NotMapped]
        public decimal Precentual => decimal.Floor(Convert.ToDecimal(Conteudo) / Convert.ToDecimal(Capacidade) * 100);
        public int TipoId { get; set; }
        public virtual Tipo Tipo { get; set; }

    }
}