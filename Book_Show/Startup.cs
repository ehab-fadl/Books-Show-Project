using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book_Show.Startup))]
namespace Book_Show
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
