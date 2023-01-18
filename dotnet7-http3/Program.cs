
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

namespace dotnet7_http3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.WebHost.ConfigureKestrel((context, options) =>
            //{
            //    options.Listen(IPAddress.Any, 5001, listenOptions =>
            //    {
            //        listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
            //        listenOptions.UseHttps();
            //    });
            //});

            var app = builder.Build();

            app.MapGet("/", (HttpContext httpContext) =>
            {
                return $"{httpContext.Request.Protocol}";
            });

            app.Run();
        }
    }
}