public class SmsService : IMessageService
{
    public void SendMessage(string text)
    {
        Console.WriteLine($"SMS sent : {text}");
    }
}