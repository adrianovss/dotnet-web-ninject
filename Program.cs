using System.Reflection;
using dotnet_web_ninject.Handler;
using dotnet_web_ninject.Logger;
using dotnet_web_ninject.NinjectConfigurations;
using Ninject;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var kernel = new StandardKernel(new Bindings());
var handler = kernel.Get<IHandler>();

app.MapGet("/", () =>
{
    handler.Execute();
});

app.Run();
