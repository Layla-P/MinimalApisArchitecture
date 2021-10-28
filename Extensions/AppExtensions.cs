using MinimalApisArchitecture.Apis;

namespace MinimalApisArchitecture.Extensions
{
    public static class AppExtensions
    {
        public static WebApplication AppMiddleware(this WebApplication app)
        {

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.GetMethods();


            return app;
        }
    }
}
