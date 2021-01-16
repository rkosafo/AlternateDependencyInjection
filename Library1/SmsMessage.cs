using Library1.Interfaces;

namespace Library1
{
    public class SmsMessage: ISmsMessage
    {
        public string phoneNumber { get; set; }
        public string message { get; set; }

        public string senderId { get; set; }
    }
}