namespace Hangfire.API.Jobs;

public class NotificationHelloJob
{
    public void Execute()
    {
        Console.WriteLine($"Hello from NotificationHelloJob at {DateTime.Now}");
    }
}