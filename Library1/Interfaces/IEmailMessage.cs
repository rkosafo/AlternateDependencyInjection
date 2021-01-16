namespace Library1.Interfaces
{
    public interface IEmailMessage
    {
        string from { get; }
        string to { get; }
        string message { get; }
        string subject { get; }
    }
}