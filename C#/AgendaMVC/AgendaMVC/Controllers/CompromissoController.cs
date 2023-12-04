using AgendaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgendaMVC.Controllers
{
    public class CompromissoController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.Db.compromissos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Contatos = new List<SelectListItem>();
            Contatos = Dados.Db.contatos.Select(c => new SelectListItem()
            { Text = c.Email, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            compromisso.Id = Dados.Db.compromissos.Max(c => c.Id) + 1;
            compromisso.Contato = Dados.Db.contatos.FirstOrDefault(c => c.Id == compromisso.Contato.Id);
            Dados.Db.compromissos.Add(compromisso);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            Compromisso compromisso = Dados.Db.compromissos.FirstOrDefault(c => c.Id == id);
            return View(compromisso);

            
        }

        [HttpPost]
        public IActionResult Editar(Compromisso compromisso)
        {
            Compromisso comp = Dados.Db.compromissos.FirstOrDefault(c => c.Id == compromisso.Id);
            comp.Descricao = compromisso.Descricao;
            comp.Data = compromisso.Data;
            Models.Contato contatoAntigo = compromisso.Contato;

            return RedirectToAction("Index");
          
        }
    }
}

