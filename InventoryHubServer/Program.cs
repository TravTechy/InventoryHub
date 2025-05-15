var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowBlazorClient",
        builder =>
        {
            builder.WithOrigins("http://localhost:5291").AllowAnyMethod().AllowAnyHeader();
        }
    );
});
builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors("AllowBlazorClient");

//add middleware for logging
app.Use(
    async (context, next) =>
    {
        // Log the request
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

        // Call the next middleware in the pipeline
        await next.Invoke();

        // Log the response
        Console.WriteLine($"Response: {context.Response.StatusCode}");
    }
);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseWebSockets();
app.UseRouting();

app.MapControllers();

app.Run();
