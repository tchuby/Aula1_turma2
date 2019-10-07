using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{
    public class PessoaController
    {
        //Realizo miha conexão com o banco e dados
        EntityContextDB contextDB = new EntityContextDB();
        public IQueryable//Aqui temos nossa peimeira Interface com a classe
            //IQuerybla essa classe contem vaias funcionalidades
            // prontas para usar igual ao banco de dados como os selects
            <Pessoa> //Definimos o tipo que ra retornar
            GetPessoas()// damos um nome ao nosso metodo
        {
            return contextDB.ListaDePessoas; // retornamos nossa lsta de pessoas
        }
        /// <summary>
        /// Metodo para adicionar pessoa ao banco de fafos          
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB // Nosso banco de dados
                .ListaDePessoas// nossa tabela Pessoa
                .Add(item);// Adicionamos o item
            contextDB.SaveChanges(); //Salvamos no banco
        }
    }
}
