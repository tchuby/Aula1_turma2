using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoFlores.Model
{
    public class Flor
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }

        public int Quantidade { get; set; } = 0;
    }
}
