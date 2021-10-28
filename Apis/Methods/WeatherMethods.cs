namespace MinimalApisArchitecture.Apis.Methods
{
    public static class WeatherMethods    {
        public static WebApplication GetWeather(this WebApplication app)
        {
            var summaries = new[]
                                        {
                                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
                            };

            app.MapGet("/weather", () =>
            {
                var forecast = Enumerable.Range(1, 5).Select(index =>
                   new Weather
                   (
                       DateTime.Now.AddDays(index),
                       Random.Shared.Next(-20, 55),
                       summaries[Random.Shared.Next(summaries.Length)]
                   ))
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeather");
            return app;
        }
        internal record Weather(DateTime Date, int TemperatureC, string? Summary)
        {
            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }
    }
}
