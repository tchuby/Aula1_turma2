using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixamos a classe publica
    public class Celular : ControleUsuario
    {
        [Key] //Chave primaria
        public int Id { get; set; }

        [MaxLength(30)]// Definicao de tamanho máximo do campo  
        [Required] // Definindo campo obrigatório
        public string Marca { get; set; }

        [MaxLength(30)]
        [Required]
        public string Modelo { get; set; }

        [Required]
        public double Preco { get; set; }
    }
}
