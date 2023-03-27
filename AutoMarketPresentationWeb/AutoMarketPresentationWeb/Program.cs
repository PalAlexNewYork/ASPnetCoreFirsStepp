using AutoMarketPresentationWeb.Data.Interface;
using AutoMarketPresentationWeb.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc((opt)=> opt.EnableEndpointRouting = false);
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();


var app = builder.Build();
app.UseDeveloperExceptionPage();// ��� ����������� ������� � ��������
app.UseStatusCodePages(); //��� ����������� ������� � ������
app.UseStaticFiles(); // ��� ������ �������������� �������
app.UseMvcWithDefaultRoute(); //��� ������������ �������� �� ��������� index.cshtml
app.Run();
