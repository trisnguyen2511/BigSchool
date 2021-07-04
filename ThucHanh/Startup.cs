using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThucHanh.Startup))]
namespace ThucHanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
