using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineExam.UI.Startup))]
namespace OnlineExam.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
