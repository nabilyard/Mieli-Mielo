using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using Owin;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(Mieli_Mielo.App_Start.AuthConfig))]
namespace Mieli_Mielo.App_Start
{
    public class AuthConfig
    {
        public  void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login/Login")
            });
        }
    }
}