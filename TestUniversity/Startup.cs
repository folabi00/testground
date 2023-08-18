using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUniversity.Startup))]
namespace TestUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
