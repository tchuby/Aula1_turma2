using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistraImoveis.Models
{
    public class Titular
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Natal { get; set; }
        public string Email { get; set; }
    }
}