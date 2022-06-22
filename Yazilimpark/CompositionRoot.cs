using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yazilimpark.Services;

namespace Yazilimpark
{
    public static class CompositionRoot
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddSingleton<IProjectService, ProjectService>();
            services.AddSingleton<IQuoteService, QuoteService>();

        }
    }
}
