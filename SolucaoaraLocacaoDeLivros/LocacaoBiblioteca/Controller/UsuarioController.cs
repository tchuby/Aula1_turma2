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
        
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"

            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Login = "tchuby",
                Senha = "yehyeh"

            });

        }

        public List<Usuario> ListaDeUsuarios { get; set; }
        public bool LoginSistema(Usuario usuarios)
        {
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
    }
}
