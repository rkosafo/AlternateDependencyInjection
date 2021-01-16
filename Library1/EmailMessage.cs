using Library1.Interfaces;

namespace Library1
{
    public class EmailMessage: IEmailMessage
    {
        public string message { get; set; }

        public string from { get; set; }

        public string to { get; set; }

        public string subject { get; set; }
    }
}