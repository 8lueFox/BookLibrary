using BookLibrary;
using BookLibrary.Services;
using ServiceReference1;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<BookService, BooksService>();
builder.Services.AddMvc();

var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapServiceWithDeniedGET<BookService>();
});

app.Run();