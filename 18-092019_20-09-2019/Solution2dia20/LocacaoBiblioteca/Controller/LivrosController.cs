using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocacaoBiblioteca.Controller
{
    namespace LivrosController
    {
        //1 - Usar nossa pasta model 'using CatalogoCelulares.Model;'
        //2 - Criar uma instancia nova da nossa Context

        //Primeiro dixamos nossa classe publica
        public class LivrosController
        {   //Iniciamos nossa instancia com a base de dados dentro da 
            //controller
            LivrosContextDB contextDB = new LivrosContextDB();
            //Listagem
            /// <summary>
            /// Metodo que retorna nossa lista de celulares ativos apenas
            /// </summary>
            /// <returns>QueryList de celulares filtrado por ativo</returns>
            public IQueryable<Livros> GetLivros()
            {
                return contextDB //Nosso acesso ao banco de dados
                    .Livros //Mossa tabela do banco de dados
                    .Where //Indicamos que vamos realizar um filtro
                    (x => x.Ativo == true); //As condições do filtro
            }
            //Atualização
            /// <summary>
            /// Metodo que atualiza um registro valido do nosso sistema
            /// </summary>
            /// <param name="item">Item que vamos atualizar</param>
            /// <returns>Retorna verdadeiro caso item exista</returns>
            public bool AtualizarLivro(Livro item)
            {
                var livro = Livros
                    .FirstOrDefault 
                    (x => x.Id == item.Id); 

               
                if (livro == null)
                {
                    item.DataAlteracao = DateTime.Now;
                }

                contextDB.SaveChanges();

                return true;