namespace Library1.Interfaces
{
    public interface ISmsMessage
    {
        string senderId { get; }
        string phoneNumber { get; }
        string message { get; }
    }
}