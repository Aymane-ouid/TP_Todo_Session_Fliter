using System.ComponentModel.DataAnnotations;

namespace Todo_SRP_DIP.ViewModels
{
    public class TodoEditVM
    {
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime DateLimite { get; set; }
        public string Statut { get; set; }

    }
}
    