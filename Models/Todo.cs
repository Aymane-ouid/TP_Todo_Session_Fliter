using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;
using Todo_SRP_DIP.Enums;
using Todo_SRP_DIP.ViewModels;

namespace Todo_SRP_DIP.Models
{
    public class Todo
    {
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime DateLimite { get; set; }
        public State Statut { get; set; }

    }
}
     