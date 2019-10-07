using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Pessoa
    {
        //Aqui temos uma antação que indica que nossa chave é 
        // o campo logo abaixo da nossa anotação e a palavra chave [Key]
        // significa que ele é nossa chave primaria
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
