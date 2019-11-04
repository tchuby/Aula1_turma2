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
        [CustomValidator]
        public DateTime Natal { get; set; } = DateTime.MinValue;
        public string Email { get; set; }
    }
}