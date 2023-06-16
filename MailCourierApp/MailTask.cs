using MailCourierApp.Services;

namespace MailCourierApp
{
    public class MailTask
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string taskName { get; set; }
        public bool isRunning { get; set; }
        public bool isStarted { get; set; }
        public int second { get; set; } = 60;
        public DateTime? NextRunning { get; set; }

        public async Task Run()
        {
            var manager = new MailManager();
            while (isStarted && !isRunning)
            {
                isRunning = true;
                //
                var fakeData = FakeDataGenerator.CreateMails(10);
                manager.AddMails(fakeData);
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
