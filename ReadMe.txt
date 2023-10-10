--------------------------------------------------------------
Add this code in program.cs

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DataConnection"));
});

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
---------------------------------------------------------------
appsettings.json

  "ConnectionStrings": {
    "DataConnection": "Server=localhost\\SQLEXPRESS;Database=AdetsisDB3;Trusted_Connection=True;TrustServerCertificate=True"
  }

---------------------------------------------------------------
Controller

private readonly IRepositoryManager _manager;

var users= _manager.User.GetAll(false);
---------------------------------------------------------------
View

@using Entities.Models;
@model IEnumerable<Entities.Models.User>

<div>
    @foreach (var user in Model)
    {
        <div>
            <h2>@user.UserName</h2>
            <p>@user.UserEmail</p>
        </div>
    }
</div>
---------------------------------------------------------------
add-migrations gelmezse Microsoft.EntityFrameworkCore.Tools indir