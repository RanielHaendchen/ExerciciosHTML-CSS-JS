using AgendaMVC.Interfaces;
using AgendaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View(new Dao.DaoContato().Consultar());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Contato contato)
        {
            /* contato.Id = Dados.Db.contatos.Count + 1;
             Dados.Db.contatos.Add(contato);*/
            // Salva contato no banco de dados   
            if (new Dao.DaoContato().salvar(contato))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            Models.Contato contato = new Dao.DaoContato().Consultar((int)id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(Models.Contato contato)
        {
            Models.Contato cont = new Dao.DaoContato().Consultar(contato.Id);

            cont.Nome = contato.Nome;
            cont.Email = contato.Email;
            cont.Telefone = contato.Telefone;

            if (new Dao.DaoContato().alterar(cont))
            {
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            Models.Contato contato = Dados.Db.contatos.FirstOrDefault(ct => ct.Id == id);
            return View(contato);
        }

        [HttpGet]
        public IActionResult Deletar(int? id)
        {
            ViewData["Id"] = id;
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmarDeletar(int id)
        {
            new Dao.DaoContato().excluir(id);
            return RedirectToAction("Index");
        }


    }
}





