using MailCourierApp.Models;
using MailCourierApp.Services;

namespace MailCourierApp.MailProviders.Base
{
    public class SmtpProvider : BaseProvider
    {
        
        public override async Task send(MailObject mailObject)
        {
            //send email simulation
            await Task.Delay(1000);
            LogService.GetInstance().Log($"Mail has sent to {mailObject.to} with SMTP");

        }
    }
}
