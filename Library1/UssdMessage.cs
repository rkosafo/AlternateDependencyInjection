using Library1.Interfaces;

namespace Library1
{
    public class UssdMessage: IUssdMessage
    {
        public string phoneNumber { get; set; }
        public string message { get; set; }

        public string conversationId { get; set; }
    }
}