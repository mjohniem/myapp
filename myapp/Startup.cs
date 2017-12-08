using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myapp.Startup))]
namespace myapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
