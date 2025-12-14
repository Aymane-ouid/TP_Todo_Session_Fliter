using Todo_SRP_DIP.Models;
using Todo_SRP_DIP.ViewModels;

namespace Todo_SRP_DIP.Mappers
{
    public class TodoMapper
    {
        public static Todo GetTodoFromTodoAddVM(TodoAddVM vm)//la classe qui non pas d'attribut on le met static, pour appelé par le nom du classe "TodoMapper" au lieu de l'objet qui est dans le controlleur.
        {
            //Todo todo = new Todo();
            ////Mappage : transformer les info du vm vers l'objet todo
            //todo.Libelle = vm.Libelle;
            //todo.Description = vm.Description;
            //todo.DateLimite = vm.DateLimite;
            //todo.Statut = vm.Statut;

            //return todo;

            return new Todo
            {
                Libelle = vm.Libelle,
                Description = vm.Description,
                DateLimite = vm.DateLimite,
                Statut = vm.Statut,
            };
        }//le code commenter et ce code la ce sont IDENTIQUE
    }
}
