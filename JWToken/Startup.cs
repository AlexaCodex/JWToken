using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWToken.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JWToken
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var auth = new AuthenticationSite();
            Configuration.GetSection("AuthenticationSite").Bind(auth);

            //DI : To pass whole config in contructor
            services.AddSingleton<AuthenticationSite>(auth);

            //DI : TO pass a section in option
            services.Configure<AuthenticationSite>(options => Configuration.GetSection("AuthenticationSite").Bind(options));


            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            app.UseMvc();
        }
    }
}
