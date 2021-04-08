using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CongDuc.Startup))]
namespace CongDuc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
