namespace Web.API;

using Application;
using FluentValidation;
using Web.API.Middlewares;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddTransient<GlobalExceptionHandlingMiddleware>();
        return services;
    }
}