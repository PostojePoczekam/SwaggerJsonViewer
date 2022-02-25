using Microsoft.Extensions.DependencyInjection;

namespace SwaggerJsonViewer
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSwaggerJsonViewer(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(PostConfigureOptions));
        }
    }
}
