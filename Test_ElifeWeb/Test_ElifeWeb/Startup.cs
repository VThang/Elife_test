using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_ElifeWeb.Startup))]
namespace Test_ElifeWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
