using BookLibrary;
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

var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapServiceWithDeniedGET<BookService>();
});

app.Run();