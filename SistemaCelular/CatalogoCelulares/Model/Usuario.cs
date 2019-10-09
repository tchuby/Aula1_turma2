using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    public class Usuario : ControleUsuario
    {
        [Key] //Defeinindo como primary key
        public int Id { get; set; }

        [MaxLength(50)] //Delimitamos o numero de carateres
        public string Nome { get; set; }

        [MaxLength(30)]
        [Required]
        public string Login { get; set; }

        [MaxLength(30)]
        [Required]
        public string Senha { get; set; }
    }
}
