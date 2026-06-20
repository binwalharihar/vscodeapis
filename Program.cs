var builder = WebApplication.CreateBuilder(args);

// 1. ADD SERVICES TO THE CONTAINER
builder.Services.AddControllers(); 
builder.Services.AddOpenApi(); // Keeps built-in .NET 9 support

// Register the Swagger generator tool
builder.Services.AddSwaggerGen(); // <-- ADD THIS LINE

var app = builder.Build();

// 2. CONFIGURE THE HTTP PIPELINE
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Generates /openapi/v1.json
    
    // Enable the visual Swagger UI playground
    app.UseSwagger();   // <-- ADD THIS LINE
    app.UseSwaggerUI(options => 
    {
        // Tells Swagger UI to look at the .NET 9 OpenAPI document structure
        options.SwaggerEndpoint("/openapi/v1.json", "My .NET 9 API v1");
    }); 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
