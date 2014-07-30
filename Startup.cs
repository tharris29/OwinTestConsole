using Owin;

namespace OwinTestConsole
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseTestOwin();
        }
    }
}