using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SedaBazi.Application.Interfaces.Contexts;
using SedaBazi.Application.Interfaces.FacadPatterns;
using SedaBazi.Application.Services.Audios.FacadPattern;
using SedaBazi.Application.Services.Email;
using SedaBazi.Application.Services.Managements.FacadPattern;
using SedaBazi.Application.Services.Payments.FacadPattern;
using SedaBazi.Application.Services.Publisher.FacadPattern;
using SedaBazi.Application.Services.Sms;
using SedaBazi.Application.Services.Users.FacadPattern;
using SedaBazi.Domain.Entities.Users;
using SedaBazi.Persistence.Contexts;

namespace EndPoint.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataBaseContext>(p => p.UseSqlServer(Configuration["ConnectionString"]));

            services.AddControllers();

            services.AddScoped<IUserFacad, UserFacad>();
            services.AddScoped<IAudioFacad, AudioFacad>();
            services.AddScoped<IManagementFacad, ManagementFacad>();
            services.AddScoped<IPublisherFacad, PublisherFacad>();
            services.AddScoped<IPaymentFacad, PaymentFacad>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ISmsService, SmsService>();
            services.AddScoped<IDataBaseContext, DataBaseContext>();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<DataBaseContext>()
                .AddDefaultTokenProviders();
        }

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

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
