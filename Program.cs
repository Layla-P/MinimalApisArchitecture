using MinimalApisArchitecture.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder
    .IocContainer()
    .Build()
    .AppMiddleware()
    .Run();