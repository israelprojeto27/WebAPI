using ClientPassRazorPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientPassRazorPage.repositories
{
    public interface IProdutoRepository
    {
        Produto GetProdutoPorId(long id);
        IList<Produto> GetProdutos();
        void Save(Produto produto);
        void Update(Produto produto);
    }
}
