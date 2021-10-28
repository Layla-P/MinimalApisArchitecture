using MinimalApisArchitecture.Apis.Methods;

namespace MinimalApisArchitecture.Apis
{
    public static class RESTMethods
    {
        public static WebApplication GetMethods(this WebApplication app)
        {
            app.GetWeather();
            return app;
        }
       
    }
}
