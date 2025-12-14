namespace Todo_SRP_DIP.Services
{
    public interface ISessionManagerService
    {
        public void Add(string key, object obj, HttpContext context);
    }
}
