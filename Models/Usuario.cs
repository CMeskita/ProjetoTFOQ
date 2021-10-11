using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoTfoq.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Column("nome", TypeName = "varchar")]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Column("senha", TypeName = "varchar")]
        [MaxLength(100)]
        public string Senha { get; set; }
        [Column("email", TypeName = "varchar")]
        [MaxLength(100)]
        public string Email { get; set; }

    }
}