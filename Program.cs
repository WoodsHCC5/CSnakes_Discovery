using CSnakes.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        var home = Path.Join(Environment.CurrentDirectory);
        services
            .WithPython()
            .WithHome(home)
            .FromRedistributable("3.12");
    });

var app = builder.Build();

var env = app.Services.GetRequiredService<IPythonEnvironment>();

var quickDemo = env.AotDemo();
var coolThings = quickDemo.CoolThings();
var home = Path.Join(Environment.CurrentDirectory);
Console.WriteLine(coolThings[0]);
app.Run();