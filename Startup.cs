using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace aspnetcoreapp
{
    public class Startup
    {
        private int count = 0;
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                count++;
                var cnt = count.ToString("D");
                var html = @"<html><head></head><body><h3>Hello from ASP.NET Core! app version 0.3 " + cnt;
                html = html + @"</h3></body></html>";
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync(html);
            });
        }
    }
}