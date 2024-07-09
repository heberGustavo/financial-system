using Entitites.Entities;
using Helpers.DependencyGroups;
using Infra.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApi.Token;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DbContext

builder.Services.AddDbContext<ContextBase>(options => options.UseSqlServer(
	builder.Configuration.GetConnectionString("DefaultConnection")
));

#endregion

#region Identity

builder.Services
				.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<ContextBase>();

#endregion

#region Dependency Injection

ServiceDependencyInjection.Register(builder.Services);
RepositoryDependencyInjection.Register(builder.Services);

#endregion

#region Authentication

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			 .AddJwtBearer(option =>
			 {
				 option.TokenValidationParameters = new TokenValidationParameters
				 {
					 ValidateIssuer = false,
					 ValidateAudience = false,
					 ValidateLifetime = true,
					 ValidateIssuerSigningKey = true,

					 ValidIssuer = "Teste.Securiry.Bearer",
					 ValidAudience = "Teste.Securiry.Bearer",
					 IssuerSigningKey = JwtSecurityKey.Create("this is my custom Secret key for authentication")
				 };

				 option.Events = new JwtBearerEvents
				 {
					 OnAuthenticationFailed = context =>
					 {
						 Console.WriteLine("OnAuthenticationFailed: " + context.Exception.Message);
						 return Task.CompletedTask;
					 },
					 OnTokenValidated = context =>
					 {
						 Console.WriteLine("OnTokenValidated: " + context.SecurityToken);
						 return Task.CompletedTask;
					 }
				 };
			 });

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
