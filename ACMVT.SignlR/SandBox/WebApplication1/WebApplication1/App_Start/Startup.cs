using Microsoft.Owin;
using Owin;
using WebApplication1;

namespace WebApplication1.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
