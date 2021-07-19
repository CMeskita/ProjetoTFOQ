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
        [MaxLength(20)]
        public string NomeTipo { get; set; }

        public bool Repor { get; set; }

        [MaxLength(20)]
        public string Tags { get; set; }

        public IEnumerable<Mantimento> Mantimentos { get; set; }
    }
}