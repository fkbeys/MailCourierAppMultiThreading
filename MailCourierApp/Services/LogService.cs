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

        public static Action<string> logAction = new Action<string>((x) => { });


        public void Log(string message)
        {
            logAction.Invoke(message);
            //act.Invoke(message);
        }


    }

}
