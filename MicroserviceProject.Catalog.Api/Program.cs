using MicroserviceProject.Catalog.Api;
using MicroserviceProject.Catalog.Api.Features.Categories;
using MicroserviceProject.Catalog.Api.Options;
using MicroserviceProject.Catalog.Api.Repository;
using MicroserviceProject.Shared.Extensions;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOptionsExtension();
builder.Services.AddDatabaseServiceExtension();
builder.Services.AddCommonServiceExtension(typeof(CatalogAssembly));


var app = builder.Build();

app.AddCategoryGroupEndpointExtenison();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.Run();


