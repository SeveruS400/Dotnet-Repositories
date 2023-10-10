--------------------------------------------------------------
Add this code in program.cs

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
---------------------------------------------------------------