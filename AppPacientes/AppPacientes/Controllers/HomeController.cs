using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppPacientes.Models;
using AppPacientes.Dados;

namespace AppPaciente.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(BancoDeDados.Instance().GetAll());
        }
    }
}
