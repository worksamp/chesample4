using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloWeb
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(context =>
            {
<<<<<<< HEAD
                return context.Response.WriteAsync("Hello World new!!!!!!");
         
         });
=======
                return context.Response.WriteAsync("Hello World!!!!!");
            });
>>>>>>> refs/heads/master
        }
    }
}
