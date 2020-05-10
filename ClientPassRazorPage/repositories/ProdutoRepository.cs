using ClientPassRazorPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Save(Produto produto)
        {
            produto.DataCadastro = new DateTime();
            produto.DataUltimaAtualizacao = produto.DataCadastro;
            dbSet.Add(produto);
            contexto.SaveChanges();
        }

        public IList<Produto> GetProdutos()
        {
            return dbSet.ToList();
        }

        public Produto GetProdutoPorId (long id)
        {
            return dbSet.Where(p => p.Id == id).SingleOrDefault();
        }

        public void Update(Produto produto)
        {
            dbSet.Update(produto);
            contexto.SaveChanges();
        }
    }
}
