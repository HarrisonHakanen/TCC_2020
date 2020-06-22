using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAnalyser.Startup))]
namespace TestAnalyser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
