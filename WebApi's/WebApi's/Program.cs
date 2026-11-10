var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers(options=>options.ReturnHttpNotAcceptable = true).AddXmlDataContractSerializerFormatters();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//When ReturnHttpNotAcceptable is set to true, ASP.NET Core returns HTTP 406 Not Acceptable if it cannot produce a response format requested by the client.
//AddXmlDataContractSerializerFormatters() adds XML support to your ASP.NET Core API, so clients can receive responses in XML instead of only JSON.