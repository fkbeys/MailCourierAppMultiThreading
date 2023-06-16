using MailCourierApp.MailProviders;
using MailCourierApp.MailProviders.Base;
using MailCourierApp.Models;
using MailCourierApp.Services;
using System.Collections.Concurrent;

namespace MailCourierApp
{
    public class MailManager
    {
        private readonly ConcurrentQueue<MailObject> _mailObjects = new ConcurrentQueue<MailObject>();
        private readonly ConcurrentDictionary<MailType, BaseProvider> _mailTypes = new ConcurrentDictionary<MailType, BaseProvider>();

        public MailManager()
        {

        }

        public void AddMails(IEnumerable<MailObject> mailObject)
        {
            foreach (var mail in mailObject)
            {
                _mailObjects.Enqueue(mail);
            }
        }

        public async Task SendAllMails()
        {
            LogService.GetInstance().Log("MailManager started");
            LogService.GetInstance().Log($"{_mailObjects.Count()} emails found...");

            //SmtpProvider smtpProvider = new SmtpProvider();
            while (_mailObjects.Count > 0)
            {
                if (_mailObjects.TryDequeue(out var mail))
                {
                    var mailProvider = MailProviderFactory.CreateProvider(mail.providerType);
                    _mailTypes.GetOrAdd(mail.providerType, mailProvider);
                    LogService.GetInstance().Log($"Sending email to {mail.to}..."); 
                    await mailProvider.send(mail);
                }
            }


            LogService.GetInstance().Log("MailManager finished the job");

        }



    }
}
