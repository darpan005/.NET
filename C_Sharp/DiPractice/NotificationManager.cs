public class NotificationManager
{
    private readonly IMessageService _messageService;

    public NotificationManager(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string text)
    {
        _messageService.SendMessage(text);
    }
}