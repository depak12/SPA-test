using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Data.SqlClient;
using WOTCStateSubmission.Classes;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

namespace WOTCStateSubmission
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
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(o =>
               {
                   o.RequireHttpsMetadata = false;
                   o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                   {
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = Configuration.GetSection("JwtIssuerOptions")["Issuer"],
                       ValidAudience = Configuration.GetSection("JwtIssuerOptions")["Audience"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("JwtIssuerOptions")["SecurityKey"])),

                   };

                  // var s = $"{PlatformServices.Default.Application.ApplicationBasePath}";
               });

            // Register your services with DI container here...


            //var connection = @"Server=(ERS-IT-LT-009); Database = WOTC; Trusted_Connection = True; MultipleActiveResultSets = true; ";
            //var connStr = Configuration.GetConnectionString("TestConnection");
            //services.AddDbContext<Classes.WOTCStateSubmissionContext>(options => options.UseSqlServer(connStr));

             //services.AddTransient<IUserStore<SynergiUser>, SynergiUserStore>();
            //  services.AddTransient<SqlConnection>(e => new SqlConnection(Configuration.GetConnectionString("Auth")));
            //  services.AddTransient<AuthService>();
            //  services.AddSingleton<CoreConfiguration>();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info() { Title = "Synergi Api", Version = "v1" });
                c.IncludeXmlComments($"{PlatformServices.Default.Application.ApplicationBasePath}/WOTCStateSubmission.xml");
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                {
                    Description = $"Accepts JWT Bearere token",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
            });

            services.AddMvc();


         //   services.AddMvc().AddJsonOptions
         //(options =>
         //{
         //    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
         //    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
         //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseMvc();

           // var t = new WOTCStateSubmission.WOTCApi();
        }
    }

    internal class SynergiUser
    {
    }
}
