using MailCourierApp.MailProviders.Base;
using MailCourierApp.Services;

namespace MailCourierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogService.logAction = addMessage;
            LogService.GetInstance().Log("application Started");
            SmtpProvider smtpProvider = new SmtpProvider();
        }
        public void addMessage(string msg)
        {
            //cross threat problem solved
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() =>
                {
                    addMessage(msg);
                }));
            }

            string message = DateTime.Now.ToString("HH:mm") + " " + msg;
            listBox1.Items.Add(message);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var mailTask = new MailTask
            {
                second = 60,
                isRunning = false,
                isStarted = false,
                NextRunning = DateTime.Now.AddDays(1),
                taskName = "initial"

            };
            mailTaskBindingSource.DataSource = new List<MailTask> { mailTask };

        }

        private void btnClearTheList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}