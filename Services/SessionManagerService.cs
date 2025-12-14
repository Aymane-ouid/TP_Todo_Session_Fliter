using System.Text.Json;
using Todo_SRP_DIP.Models;

namespace Todo_SRP_DIP.Services
{
    public class SessionManagerService : ISessionManagerService
    {
        public void Add(string key, object obj, HttpContext context)
        {
            string chaine = JsonSerializer.Serialize(obj);//pour convertir la list en chaine de caractere pour etre possible de stocker la liste dans la session ,
            context.Session.SetString(key, chaine);
        }
    }
}
    