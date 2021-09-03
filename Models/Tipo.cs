using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    [Table("Tipo")]
    public class Tipo
    {//Criando Entidades no banco 1° Passo
        [Key]

        public int Id { get; set; }

        [Column("nome", TypeName = "varchar")]
        [MaxLength(100)]
        public string Nome { get; set; }
           
        [Column("repor")]
        public bool Repor { get; set; }

        [Column("tags", TypeName = "varchar")]
        [MaxLength(100)]
        public string Tags { get; set; }

        public virtual IList<Mantimento> Mantimentos { get; set; }
    }
}