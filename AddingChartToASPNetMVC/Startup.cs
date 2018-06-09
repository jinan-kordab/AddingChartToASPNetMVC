using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddingChartToASPNetMVC.Startup))]
namespace AddingChartToASPNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
