using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contém os metodos de usuários do sistema
    /// Para realizar o login padrão use:
    /// - Login: Adimn
    /// - Senha: Admin
    /// </summary>
    /// <param name="Usuario"> Passamos um objeto de nome Usuario como parametro</param>
    /// <returns>Retorna verdadeiro quando eistir  usuário com este login e senha<returns>
    public class UsuarioController
    {
        private int IdContador = 0;
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                //Adiciona o Id contador incrementando o mesmo com ele +1 "++"
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"

            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContador++,
                Login = "tchuby",
                Senha = "yehyeh"

            });

        }

        private List<Usuario> ListaDeUsuarios { get; set; }
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        /// <summary>
        /// Metodo usado para adicionar um novo suario no sisttema
        /// </summary>
        /// <param name="usuario">Novo usuario que será adicionado a lista</param>
        public void AcidionarUsuario(Usuario usuario)
        {
            usuario.Id = IdContador++;
            ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo que retorna nossa lista interna de usuarios
        /// </summary>
        /// <returns>Lista contendo os usuarios</returns>
        public List<Usuario> RestornaListaDeUsuarios()
        {
            return ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>(); 
        }

        /// <summary>
        /// Metodo que desativa um registro de usuario em nssa lista
        /// </summary>
        /// <param name="identificadoID">Paramentri que identifica  usuario qe sera desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo FirstorDefault para localizar nosso usuario dentro da lista
            //com isso conseguimos acessar as propriedades dele e desativar o registro
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }
}
