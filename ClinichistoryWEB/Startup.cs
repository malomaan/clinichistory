using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinichistoryWEB.Startup))]
namespace ClinichistoryWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
