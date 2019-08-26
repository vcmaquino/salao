using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalaoMVC.Models;
using ProjetoSalaoMVC.Models.ViewsModel;
using ProjetoSalaoMVC.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoSalaoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LoginViewModel vm = new LoginViewModel();

            var TipoUsuarioLista = new[]
            {
                new {Value = 0,Type = Enum.GetName(typeof(TipoUsuario), 0)},
                new {Value = 1,Type = Enum.GetName(typeof(TipoUsuario), 1)},
                new {Value = 2,Type = Enum.GetName(typeof(TipoUsuario), 2)},
                new {Value = 3,Type = Enum.GetName(typeof(TipoUsuario), 3)},

            };
     
                                                    
            vm.ActionsList = from action in TipoUsuarioLista
                             select new SelectListItem
                             {
                                 Text = action.Type.ToString(),
                                 Value = action.Value.ToString()
                             };
            return View(vm);
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel loginViewModel)
        {
            var usuario = loginViewModel.usuario;
            var senha = loginViewModel.senha;
            var tipoUsuario = loginViewModel.tipoUsuario;

            //vai estourar erro aqui :D n arrumei
            //tambem não limpa a sessão :D
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
