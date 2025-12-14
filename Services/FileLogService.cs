namespace Todo_SRP_DIP.Services
{
    public class FileLogService : ILogService
    {
        public void Log(string message)
        {
            if (!Directory.Exists("Logs"))
                Directory.CreateDirectory("Logs");

            File.AppendAllText("Logs/log.txt", message + Environment.NewLine);
        }
    }
}
