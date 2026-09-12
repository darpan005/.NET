public class EmailService : IMessageService
{
    public void SendMessage(string text)
    {
        Console.WriteLine($"Email sent : {text}");
    }
}