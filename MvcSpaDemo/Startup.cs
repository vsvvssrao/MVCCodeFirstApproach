using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSpaDemo.Startup))]
namespace MvcSpaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
