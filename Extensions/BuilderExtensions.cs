namespace MinimalApisArchitecture.Extensions
{
    public static class BuilderExtension
    {
        public static WebApplicationBuilder IocContainer(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            return builder;
        }
    }
}