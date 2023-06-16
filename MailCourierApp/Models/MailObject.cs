namespace MailCourierApp.Models
{
    public class MailObject
    {
        public string to { get; set; }
        public MailType providerType { get; set; }
        public string from { get; set; } = "fkbeys@gmail.com";
    }

    public enum MailType
    {
        None = 0,
        Smtp = 1,
        Pop3 = 2,
    }
}
