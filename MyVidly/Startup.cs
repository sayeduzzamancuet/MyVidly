using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVidly.Startup))]
namespace MyVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
