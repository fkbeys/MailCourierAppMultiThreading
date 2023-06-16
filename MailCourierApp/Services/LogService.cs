namespace MailCourierApp.Services
{
    public class LogService
    {
        private LogService()
        {

        }
        private static readonly Lazy<LogService> logService = new Lazy<LogService>(() => new LogService());

        public static LogService GetInstance()
        {
            return logService.Value;
        }

        public Action<string> onLogAdded;
        public void Log(string message)
        {
            onLogAdded.Invoke(message);
        }


    }

}
