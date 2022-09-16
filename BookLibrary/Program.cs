using BookLibrary;
using BookLibrary.Common.Behaviors;
using BookLibrary.Services;
using MediatR;
using ServiceReference1;
using SoapCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<BookService, BooksService>();
builder.Services.AddMvc();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddTransient(typeof(IPipelineBehavior<,>),typeof(LoggingBehavior<,>));

var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapServiceWithDeniedGET<BookService>();
});

app.Run();