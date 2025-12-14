using System.ComponentModel.DataAnnotations;
using Todo_SRP_DIP.Enums;

namespace Todo_SRP_DIP.ViewModels
{
    public class TodoAddVM
    {
        [Required(ErrorMessage = "Le libelle est obligatoire")]
        public string Libelle { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateLimite { get; set; }
        [Required]
        public State Statut { get; set; } // TODO, DOING, DONE
    }
}
