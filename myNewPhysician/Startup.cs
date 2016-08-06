using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myNewPhysician.Startup))]
namespace myNewPhysician
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
