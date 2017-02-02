using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MembersIacv.Startup))]
namespace MembersIacv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
