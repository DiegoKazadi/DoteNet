using AppPacientes.Dados;
using AppPacientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppPaciente.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            int id = BancoDeDados.Instance().GetAll().Count + 1;
            paciente
                .Id = id;

            BancoDeDados.Instance().Add(paciente);

            ViewData["exibirAlert"] = true;

            ModelState.Clear();

            return View("Cadastrar");
        }

        public IActionResult Deletar(int id)
        {
            BancoDeDados.Instance().Remover(id);
            return RedirectToAction("Index", "Home");
        }
    }
}