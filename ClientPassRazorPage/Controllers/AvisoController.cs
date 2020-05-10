using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientPassRazorPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientPassRazorPage.Controllers
{
    public class AvisoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]        
        public IActionResult Create(Aviso aviso)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Aviso cadastrado com sucesso !!!";
            }            
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(long Id)
        {
            return View();
        }

        public IActionResult View()
        {
            return View();
        }

        public IActionResult View(long Id)
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Delete(long Id)
        {
            return View();
        }

    }
}