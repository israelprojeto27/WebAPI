using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ClientPassRazorPage.api;
using ClientPassRazorPage.Models;
using ClientPassRazorPage.repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClientPassRazorPage.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;
        private ProdutoAPI _api = new ProdutoAPI();


        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> Delete(long id)
        {
            //Comentario
            ProdutoData produto = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/produto/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                produto = JsonConvert.DeserializeObject<ProdutoData>(results);
            }

            ViewBag.Produto = produto;
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(Produto produto)
        {            
            // Segundo Comentario
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.DeleteAsync("RemoveProduto/" + produto.Id);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Lista");

            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Atualiza(long id)
        {
            ProdutoData produto = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/produto/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                produto = JsonConvert.DeserializeObject<ProdutoData>(results);
            }

            ViewBag.Produto = produto;
            return View();
        }

        [HttpPost]
        public IActionResult Atualiza(Produto produto)
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44399/");

                var puttJob = client.PutAsJsonAsync<Produto>("AtualizaProduto", produto);
                puttJob.Wait();

                var postResult = puttJob.Result;
                if (postResult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Lista");
                }
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Detalhe(long id)
        {
            ProdutoData data = new ProdutoData();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/produto/" + id);
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<ProdutoData>(results);
            }
            return View(data);
            
        }


        [HttpPost]
        public IActionResult Cadastra(Produto produto)
        {
            using( var client = new HttpClient())
            {

                client.BaseAddress = new Uri("https://localhost:44399/api/produto");

                var postJob = client.PostAsJsonAsync<Produto>("produto", produto);
                postJob.Wait();

                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                {
                    return RedirectToAction("Lista");
                }
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<ProdutoData> lista = new List<ProdutoData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/produto");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<ProdutoData>>(results);
            }
            return View(lista);

        }



        public IActionResult Index()
        {
            ViewBag.ListaProdutos = _repository.GetProdutos();
            return View();
        }

        public IActionResult Create()
        {           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {            
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Produto cadastrado com sucesso !!!";
                _repository.Save(produto);
            }
           
            return View();
        }

        public IActionResult Edit(long id)
        {
            Produto produto = _repository.GetProdutoPorId(id);
            ViewBag.Produto = produto;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(produto);                
                ViewBag.Produto = produto;
                ViewBag.Message = "Produto atualizado com sucesso";
            }
            
            return View();
        }
    }
}