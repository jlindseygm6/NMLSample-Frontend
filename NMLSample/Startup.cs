using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NMLSample.Startup))]
namespace NMLSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
