using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace OwinTestConsole
{
    public class TestOwinMiddleWare : OwinMiddleware
    {
        public TestOwinMiddleWare(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext owinContext)
        {
            try
            {
                var output = Encoding.UTF8.GetBytes("some plain text");
                owinContext.Response.Body.Write(output, 0, output.Length);
                owinContext.Response.ContentType = "application/json";

                owinContext.Response.ContentLength = output.Length;// code will error here because the contentlength has already been sent
            }
            catch (Exception e)
            {
                var output = Encoding.UTF8.GetBytes(e.ToString());
                owinContext.Response.StatusCode = 500;// also note at this point the status code also cannot be updated.
                owinContext.Response.Body.Write(output, 0, output.Length);
            }
            await Next.Invoke(owinContext);
        }
    }
}