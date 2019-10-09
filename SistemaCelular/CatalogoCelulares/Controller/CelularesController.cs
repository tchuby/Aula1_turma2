using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    

    //Primeiro deixamos publica
    public class CelularesController
    {
        //Using a pasta CatalogoCelulares.Model
        //Instanciar  a context
        CelularesContextDB contextDB = new CelularesContextDB();

        //Listagem
        /// <summary>
        /// Metodo que retorna lista de celulares ativos apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB // Nosso Acesso ao banco de dados
                    .Celulares// Nossa tabela
                    .Where //Filtro
                    (x => x.Ativo == true); //Condição do filtro        
        }

        //Atualização
        /// <summary>
        /// Metodo que atulaiza um registro valido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro  caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = // Definimos uma variável para o celular
                contextDB // Usamos o bando de Dados
                .Celulares // A tabela que tem os celulares
                .FirstOrDefault //Busca na tabela o ceular
                (x => x.Id == item.Id); //parametro para busca

            //Falamos que nosso celular da tabeka ai ser igual 
            //Nosso celular que estamos passando
            if (celular == null) // Verificamos se realmente enontrou um celular
                return false;// Caso não tenha encontrado retornamos falso
            else
            { 
                celular = item; // Encontrou e atualiza a informação
                celular.DataAlteracao = DateTime.Now; //Atualizamos a datada alteração
            }
            contextDB.SaveChanges(); //Salvamos a informação no banco

            return true; //retornamos que foi atulizado
        }
        //Inserção
        /// <summary>
        /// Metodo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string //Nosso tipo que contem varios metsod prontos para string
                .IsNullOrWhiteSpace // Metodo que identifica epaçoes em branco
                                    //apenas ou Valor Null
                (item.Marca)) //Nosso campo que vamos validar
                return false;
            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;
            if (item.Preco <= 0)//Verificamos se o valor informado é maior que 0
                return false;// Caso não, ele já retorna para fora do metodo

            //Salvamos nosso item dentro de nossa tabela em memoria
            contextDB.Celulares.Add(item);
            //Salvamos agora no banco esta informação
            contextDB.SaveChanges();
            //Retornamos cerdadeiro para incicar sudess na insersão 
            return true;
        }
        //'Remoção'
        /// <summary>
        /// Metodo utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //Nossa variável
                contextDB //Nosa base de dados
                .Celulares //Tabela de celulares
                .FirstOrDefault // Buscamos o item para desativar
                (x => x.Id == id); //parametro de busca

            if (celular == null) //Verificar a existencia do item
                return false; //Caso negativo sair do metodo

            celular.Ativo = false; //Desativa o item

            contextDB.SaveChanges();//Salva no banco

            return true;//Retorna verdadeiro
        }
    }
}
