using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UdemyAPI.Library;
using UdemyAPI.Library.Repositories;
using UdemyAPI.Library.Services;

namespace UdemyAPI
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
            var migrationAssemblyName = typeof(Startup).Assembly.FullName;
            var connection = Configuration.GetConnectionString("DefaultConnection");

            services
                .AddTransient<IAuthorRepository, AuthorRepository>()
                .AddTransient<IAuthorService, AuthorService>()
                .AddTransient<ICourseRepository, CourseRepository>()
                .AddTransient<ICourseService, CourseService>()
                .AddTransient<ITagRepository, TagRepository>()
                .AddTransient<ITagService, TagService>()
                .AddTransient<IUdemyUnitOfWork, UdemyUnitOfWork>(x => new UdemyUnitOfWork(connection, migrationAssemblyName))
                .AddTransient<UdmeyContext>(x => new UdmeyContext(connection, migrationAssemblyName));

            services
                .AddDbContext<UdmeyContext>(x => x.UseSqlServer(connection,
                                                        m => m.MigrationsAssembly(migrationAssemblyName)));
            services.AddControllers();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
