using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Todo_SRP_DIP.Mappers;
using Todo_SRP_DIP.Models;
using Todo_SRP_DIP.Services;
using Todo_SRP_DIP.ViewModels;

namespace Todo_SRP_DIP.Controllers
{
    public class TodosController : Controller
    {
        ISessionManagerService session;//Injection de dependance
        public TodosController(ISessionManagerService session)
        {
            this.session = session;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(TodoAddVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            List<Todo> list;
            if(HttpContext.Session.GetString("Todos") == null)  
            {
                list = new List<Todo>();
            }
            else
            {
                //J'ai déja des todo dans la liste !
                list = JsonSerializer.Deserialize<List<Todo>>(HttpContext.Session.GetString("Todos")); //et pour l'affichage on doit faire la deserialisation pour convertir la chaine a une list
            }


           Todo todo = TodoMapper.GetTodoFromTodoAddVM(vm);

            list.Add(todo);

            
            // Couplage faible : Une classe X Doit etre capable d'utiliser une classe Y, sans l'appeler, sans utiliser sans Nom
            // D = Injection de dependance  + liaison avec les abstraction (les interfaces)
            session.Add("Todos", list, HttpContext);
            

            return RedirectToAction(nameof(Index));
        }
    }
}
