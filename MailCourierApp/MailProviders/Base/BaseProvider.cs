using MailCourierApp.Models;

namespace MailCourierApp.MailProviders.Base
{
    public abstract class BaseProvider
    {
        public int port { get; set; }
        public string serverHostName { get; set; } = "smtp.google.com";
        public abstract void send(MailObject mailObject);
    }
}
