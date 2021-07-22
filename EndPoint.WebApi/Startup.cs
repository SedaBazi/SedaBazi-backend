using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Services.Email;
using SedaBazi.Application.Services.Users.Commands.ForgotPassword;
using SedaBazi.Application.Services.Users.Commands.LoginUser;
using SedaBazi.Application.Services.Users.Commands.LogoutUser;
using SedaBazi.Application.Services.Users.Commands.RegisterUser;
using SedaBazi.Domain.Entities.Users;
using SedaBazi.Persistence.Contexts;

namespace EndPoint.WebApi
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
            services.AddDbContext<DataBaseContext>(p => p.UseSqlServer(@"Data Source=DESKTOP-L5RR2V4; Initial Catalog=Test2; Integrated Security=True;"));

            services.AddControllers();

            services.AddScoped<IDataBaseContext, DataBaseContext>();
            services.AddScoped<IRegisterUserService, RegisterUserService>();
            services.AddScoped<ILoginUserService, LoginUserService>();
            services.AddScoped<ILogoutUserService, LogoutUserService>();
            services.AddScoped<IForgotPasswordService, ForgotPasswordService>();
            services.AddScoped<IEmailService, EmailService>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DataBaseContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
