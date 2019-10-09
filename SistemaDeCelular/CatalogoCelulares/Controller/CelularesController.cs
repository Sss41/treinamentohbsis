using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
   public class CelularesController
    {
        CelularesContextDB ContextDb = new CelularesContextDB();
        //Listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>QuerList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return ContextDb.Celulares.Where(x => x.Ativo == true);
        }
        //Atualizacao
        /// <summary>
        /// Metod que atualiza um registro dentro do nosso sistema 
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>REtorna verdadeiro cas item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = ContextDb.Celulares.FirstOrDefault (x => x.Id == item.Id);
            if (celular == null)
                return false;
            else
            {
                celular = item;
                celular.DataAlteracao = DateTime.Now; 

            }
            ContextDb.SAveChanges();
            return true;
        }
        //Insercao
        /// <summary>
        /// Metdo que valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item </returns>
        public bool InserirCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0)
                return false;

            ContextDb.Celulares.Add(item);
            ContextDb.SAveChanges();
            return true;
        }
        //remoção(Atualizando o status)
        /// <summary>
        /// metodo para  apenas desativar o itme dentro do nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar </param>
        /// <returns>Retorna verdadeiro em caso de suceso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular =// nossa variavel
              ContextDb.Celulares.FirstOrDefault(x => x.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;

            ContextDb.SaveChanges();

            return true;

        }

    }
}
