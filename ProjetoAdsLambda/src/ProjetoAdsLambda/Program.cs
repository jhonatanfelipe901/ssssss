using ProjetoAds.Application.Application;
using ProjetoAds.Application.Contracts;
using ProjetoAds.CrossCutting.ExtensionMethods;
using ProjetoAds.CrossCutting.Helpers.Auth.Services;
using ProjetoAds.CrossCutting.Settings;
using ProjetoAds.Data.Repository;
using ProjetoAds.Domain.Repository;
using ProjetoAds.Domain.Service;
using ProjetoAds.Domain.Service.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add AWS Lambda support. When application is run in Lambda Kestrel is swapped out as the web server with Amazon.Lambda.AspNetCoreServer. This
// package will act as the webserver translating request and responses between the Lambda event source and ASP.NET Core.
builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

ConfigureSettings(builder);
ConfigureServices(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/", () => "Welcome to running ASP.NET Core Minimal API on AWS Lambda");

app.Run();

void ConfigureSettings(WebApplicationBuilder builder)
{
    var settings = new Settings();
    builder.Configuration.GetSection("ConnectionStrings").Bind(settings);
}

void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddControllers();

    builder.Services.AddTransient<IUserApplication, UserApplication>();
    builder.Services.AddTransient<IUserService, UserService>();
    builder.Services.AddTransient<IUserRepository, UserRepository>();

    builder.Services.AddTransient<IEvaluationApplication, EvaluationApplication>();
    builder.Services.AddTransient<IEvaluationRepository, EvaluationRepository>();

    builder.Services.AddTransient<IGoodBrowserGameApplication, GoodBrowserGameApplication>();
    builder.Services.AddTransient<IGoodBrowserGameService, GoodBrowserGameService>();
    builder.Services.AddTransient<IGoodBrowserGameRepository, GoodBrowserGameRepository>();

    builder.Services.AddScoped<IAuthApplication, AuthApplication>();
    builder.Services.AddScoped<ITokenService, TokenService>();
}
