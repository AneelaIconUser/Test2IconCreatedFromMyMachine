using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubTest2.Startup))]
namespace GitHubTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
