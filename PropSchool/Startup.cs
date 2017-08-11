using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PropSchool.Startup))]
namespace PropSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
