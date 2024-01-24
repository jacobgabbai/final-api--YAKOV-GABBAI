using Microsoft.AspNetCore.Builder;
using System.Text.Json.Serialization;

namespace final_api_19
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureSurvices(IServiceCollection services)
        {
            services.AddControllers()
       .AddJsonOptions(options =>
       {
           options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
       });



        }
    }
}
