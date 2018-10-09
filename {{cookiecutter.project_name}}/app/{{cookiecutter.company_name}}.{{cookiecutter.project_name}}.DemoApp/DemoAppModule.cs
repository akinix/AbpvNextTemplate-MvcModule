using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Swagger;
using Volo.Abp;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Modularity;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Identity.Web;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Threading;
using Volo.Abp.VirtualFileSystem;

namespace {{cookiecutter.company_name}}.{{cookiecutter.project_name}}.DemoApp
{
    [DependsOn(
        typeof({{cookiecutter.project_name}}WebModule),
        typeof({{cookiecutter.project_name}}ApplicationModule),
        typeof({{cookiecutter.project_name}}EntityFrameworkCoreModule),

        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),

        typeof(AbpAccountWebModule),
        typeof(AbpIdentityWebModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule)
        )]
    public class DemoAppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.BuildConfiguration();

            context.Services.Configure<DbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = configuration.GetConnectionString("Default");
            });

            context.Services.Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            if (hostingEnvironment.IsDevelopment())
            {
                context.Services.Configure<VirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPyhsical<{{cookiecutter.project_name}}WebModule>(Path.Combine(hostingEnvironment.ContentRootPath, "..\\..\\src\\{{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Web"));
                    options.FileSets.ReplaceEmbeddedByPyhsical<{{cookiecutter.project_name}}DomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, "..\\..\\src\\{{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Domain"));
                    options.FileSets.ReplaceEmbeddedByPyhsical<{{cookiecutter.project_name}}ApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, "..\\..\\src\\{{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Application"));
                    options.FileSets.ReplaceEmbeddedByPyhsical<{{cookiecutter.project_name}}ApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, "..\\..\\src\\{{cookiecutter.company_name}}.{{cookiecutter.project_name}}.Application.Contracts"));
                });
            }

            context.Services.AddSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new Info { Title = "Blogging API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                });

            context.Services.Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                //...add other languages
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();

            if (context.GetEnvironment().IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseErrorPage();
            }

            app.UseVirtualFiles();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Support APP API");
            });

            app.UseAuthentication();
            app.UseAbpRequestLocalization();
            app.UseAuditing();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            AsyncHelper.RunSync(async () =>
            {
                await context.ServiceProvider
                    .GetRequiredService<IIdentityDataSeeder>()
                    .SeedAsync(
                        "1q2w3E*",
                        IdentityPermissions.GetAll().Union({{cookiecutter.project_name}}Permissions.GetAll())
                    );
            });
        }
    }
}
