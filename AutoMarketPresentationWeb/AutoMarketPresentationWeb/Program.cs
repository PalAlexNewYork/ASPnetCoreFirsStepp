using AutoMarketPresentationWeb.Data.Interface;
using AutoMarketPresentationWeb.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc((opt)=> opt.EnableEndpointRouting = false);
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();


var app = builder.Build();
app.UseDeveloperExceptionPage();// дл€ отображени€ страниц с ошибками
app.UseStatusCodePages(); //дл€ отображени€ страниц с кодами
app.UseStaticFiles(); // дл€ работы состатическими файлами
app.UseMvcWithDefaultRoute(); //дл€ обтображени€ страницы по умолчанию index.cshtml
app.Run();
