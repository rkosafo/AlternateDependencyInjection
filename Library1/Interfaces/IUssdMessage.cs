namespace Library1.Interfaces
{
    public interface IUssdMessage
    {
        string phoneNumber { get; }
        string message { get; }
        string conversationId { get; }
    }
}