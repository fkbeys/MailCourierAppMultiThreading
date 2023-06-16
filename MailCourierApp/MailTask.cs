using MailCourierApp.Models;
using MailCourierApp.Services;

namespace MailCourierApp
{
    public class MailTask
    {
        public readonly MailType mailType;

        public MailTask(MailType mailType)
        {
            this.mailType = mailType;
        }

        public Guid id { get; set; } = Guid.NewGuid();
        public string taskName { get; set; }
        public bool isRunning { get; set; }
        public bool isStarted { get; set; }
        public int second { get; set; } = 60;
        public DateTime? NextRunning { get; set; }

        public async Task Run(MailType mailType)
        {
            var manager = new MailManager();
            while (isStarted && !isRunning)
            {
                isRunning = true;

                var mailobjects = mailType == MailType.Smtp ? FakeDataGenerator.SmtpMailCreate(10) : FakeDataGenerator.Pop3MailCreate(10);

                manager.AddMails(mailobjects);
                await manager.SendAllMails();

                isRunning = false;

                NextRunning = DateTime.Now.AddSeconds(second);
                await Task.Delay(second * 1000);

            }
        }

        public async Task Start()
        {

            isStarted = true;
            NextRunning = DateTime.Now.AddSeconds(second);

        }

        public async Task Stop()
        {
            isStarted = false;
            NextRunning = null;
        }

    }
}
