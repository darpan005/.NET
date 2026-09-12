using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Register services
services.AddTransient<IMessageService, SmsService>();
services.AddTransient<NotificationManager>();

var provider = services.BuildServiceProvider();

// Run the application
var manager = provider.GetRequiredService<NotificationManager>();
manager.Notify("Hello from Dependency Injection!");