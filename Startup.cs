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
                var html = count.ToString("D");
                html = @"<html><head></head><body><h3>Hello from ASP.NET Core! " + html;
                html = html + @"</h3></body></html>";
                context.Response.ContentType = "text/html";
                await context.Response.WriteAsync(html);
            });
        }
    }
}