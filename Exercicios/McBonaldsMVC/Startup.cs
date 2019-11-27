﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace McBonaldsMVC {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddDistributedMemoryCache ();

            // services.AddSession (options => {
            //     // Set a short timeout for easy testing.
            //     options.IdleTimeout = TimeSpan.FromSeconds (10);
            //     options.Cookie.HttpOnly = true;
            //     // Make the session cookie essential
            //     options.Cookie.IsEssential = true;
            // });

            services.Configure<CookiePolicyOptions> (options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1);
            
            services.AddSession(options =>
            {
                options.Cookie.Name = ".Hamburgueria.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(15);
                options.Cookie.IsEssential = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseSession();
            
            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            // Se não ficar aqui, o TempData não funciona
            app.UseCookiePolicy ();
            
        }
    }
}