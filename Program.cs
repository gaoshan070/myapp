// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

// app.MapGet("/weatherforecast", () =>
// {
//     var forecast =  Enumerable.Range(1, 5).Select(index =>
//         new WeatherForecast
//         (
//             DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
//             Random.Shared.Next(-20, 55),
//             summaries[Random.Shared.Next(summaries.Length)]
//         ))
//         .ToArray();
//     return forecast;
// })
// .WithName("GetWeatherForecast")
// .WithOpenApi();

// app.Run();

// record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
// {
//     public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
// }

// using System.Reflection;
// using System;

// Assembly? myApp = Assembly.GetEntryAssembly();

// if (myApp is null) return;

// foreach (AssemblyName name in myApp.GetReferencedAssemblies())
// {
//     Assembly a = Assembly.Load(name);
//     try
//     {
//         int methodCount =  0;
//         foreach (TypeInfo t in a.DefinedTypes)
//         {
//             methodCount += t.GetMethods().Length;
//         }

//         Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
//             arg0: a.DefinedTypes.Count(),
//             arg1: methodCount,
//             arg2: name.Name);
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine("exception happend: {0}", e.Message);
//     }

// }

// static void Main(string[] args)
// {

// }

using System.Diagnostics;

// Debug.WriteLine("Hello world!!!!");
// TimesTable(7);
// ConfigureConsole();
// ConfigureConsole(culture: "fr-FR");
// ConfigureConsole(useComputerCulture: true);
// decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

WriteLine(nameof(unitsInStock));
// Trace.WriteLine($"You must pay {taxToPay:C} in tax.");