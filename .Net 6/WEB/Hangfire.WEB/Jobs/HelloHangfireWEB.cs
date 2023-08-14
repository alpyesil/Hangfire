namespace Hangfire.WEB.Jobs;

public class HelloHangfireWEB
{
    public void Execute()
    {
        Console.WriteLine($"Hello from NotificationHelloJob at {DateTime.Now}");
    }
}