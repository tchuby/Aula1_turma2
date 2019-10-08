using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos tornar a classe pública
    public class Cerveja
    {
        //Chamada pelo (Ctrl + ".")
        [Key] //Chave primaria, auto incrementada
        public int Id { get; set; }

        [StringLength(50)] //Quantidade máxima de caracteres para o campo Nome
        [Required] // = NOT NULL
        public string Nome { get; set; }

        [StringLength(30)]
        public string Tipo { get; set; }

        public double Teor { get; set; }
    }
}
