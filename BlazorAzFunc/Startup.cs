using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorAzFunc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // install-package Microsoft.AspNetCore.Cors
            // The Azure Function still needs CORS set, do NOT add a trailing /
            services
                .AddCors
                (
                    options =>
                        options.AddDefaultPolicy
                        (
                            builder =>
                                builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials()
                        )
                );
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
