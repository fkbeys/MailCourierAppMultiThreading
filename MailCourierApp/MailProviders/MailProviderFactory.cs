using MailCourierApp.MailProviders.Base;
using MailCourierApp.Models;

namespace MailCourierApp.MailProviders
{
    public class MailProviderFactory
    {
        public static BaseProvider CreateProvider(MailType mailType)
        {

            return mailType switch
            {
                MailType.Smtp => new SmtpProvider(), 
                MailType.Pop3 => new Pop3Provider(),
                _ => throw new NotImplementedException(),
            };
        }

    }
}
