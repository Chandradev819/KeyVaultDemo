using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

if (builder.Environment.IsDevelopment())
{
    var keyVaultURL = new Uri(builder.Configuration.GetSection("KeyVault:KeyVaultURL").Value!);
    var azureCredensial = new DefaultAzureCredential();
    builder.Configuration.AddAzureKeyVault(keyVaultURL, azureCredensial);
    var ProdConnection = builder.Configuration.GetSection("DefaultConnection").Value;

    //builder.Services.AddDbContext<EmpDatabaseContext>(options =>
    //{
    //    options.UseSqlServer(client.GetSecret("ProdConnection").Value.Value.ToString());
    //});
}
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
