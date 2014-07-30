using Owin;

namespace OwinTestConsole
{
    public static class AppBuilderExtensions
    {
        public static IAppBuilder UseTestOwin(this IAppBuilder builder)
        {
            return builder.Use(typeof(TestOwinMiddleWare));
        }
    }
}