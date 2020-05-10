using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientPassRazorPage.api
{
    public class ProdutoAPI
    {
        public HttpClient Initial()
        {
            // https://localhost:44399/api/produto
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44399/");
            return client;
        }
        

    }
}
