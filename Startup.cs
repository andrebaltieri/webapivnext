using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;

public class Startup
{
    public void Configure(IBuilder app)
    {
        app.UseServices(services =>
        {
            services.AddMvc();
        });

        app.UseMvc(routes =>
        {
            routes.MapRoute("ApiRoute", "{controller}/{id?}");            
        });

    }
}