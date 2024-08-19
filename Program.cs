using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); //default.html,default.htm, index.html, index.htm for endpoint "/"
app.UseStaticFiles(); //add support static files

//using parameters
app.MapGet("/contact/{name}/{surname}", (string name, string surname) => $"Contact me {name} {surname}!");
app.MapGet("/contact/{name}", (string name) => $"Contact me {name}!");
app.MapGet("/shop/contact", () => "Shops contact!");
app.MapGet("/about", () => "About me!!!");
//app.MapGet("/", () => "Hello World!");

app.Run();
