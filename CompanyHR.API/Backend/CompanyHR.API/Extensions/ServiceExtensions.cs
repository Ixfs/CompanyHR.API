// AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

// Фоновые службы
builder.Services.AddHostedService<EmployeeNotificationService>();

// SignalR (если используете)
builder.Services.AddSignalR();

// Redis
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});