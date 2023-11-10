using DrogueriaUI.Models;
using DrogueriaUI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DrogueriaUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericRepository<Cliente> _clienteRepository;

        public HomeController(IGenericRepository<Cliente> genericRepository)
        {
            this._clienteRepository = genericRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Registro(Cliente modelo)
        {
           
            

            var resultado = await this._clienteRepository.Insertar(modelo);
            if (resultado.Id!=0)
            {

                return RedirectToAction("Index", "Home");
            }
            else
            {

                return View(modelo);
            }

        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ObtenerTodos()
        {
            var clientes = await this._clienteRepository.ObtenerTodos();            

            return View(clientes);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}