using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixar a classe pública
    public class ControleUsuario
    {
        //Definimos o campo com o valor default 'true'
        public bool Ativo { get; set; } = true;

        //Definimos 0 para usuario criado pelo sistema sem usuario logado
        public int UsuarioCriacao { get; set; } = 0;

        //Definimos 0 para usuario criado pelo sistema sem usuario logado
        public int UsuarioAlteracao { get; set; } = 0;
        
        // Setamos nossa data de criação para a data atual pela classe DateTime
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        //Aqui definimos quandi não informado para data de alteração a data atual
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

    }
}
