﻿using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.DependencyInjection;
using Twitter.WebModel.Models;

namespace Twitter.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFramework()
                .AddSqlServer()
                .AddDbContext<ApplicationContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseIdentity();
            app.UseMvc();
        }
    }
}