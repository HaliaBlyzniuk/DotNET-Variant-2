using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text;

namespace Blyzniuk_Lab3
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PhoneTalkContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
        }

        private static string Index
        {
            get
            {
                StringBuilder result = new StringBuilder(
                string.Format("<table><tr><th>{0}</th><th>{1}</th><th>{2}</th></tr>",
                    "Name", "Code", "Rate"
                ));
                PhoneTalkContext context = new PhoneTalkContext();
                try
                {
                    foreach (var firm in context.Cities.OrderBy(f => f.Name).ToList())
                        result.Append(string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>",
                                firm.Name, firm.Code, firm.Rate
                            ));
                    result.Append("</table><style>table,tr,td,th{border: 1px solid black;} table{border-collapse: collapse;}</style>");
                }
                catch (Exception e)
                {
                    result.Clear().Append($"<h1>{e.Message}</h1>");
                }               
                return result.ToString();
            }
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapGet("/", async httpContext => {
                    await httpContext.Response.WriteAsync(Index);
                });
            });
        }
    }
}
