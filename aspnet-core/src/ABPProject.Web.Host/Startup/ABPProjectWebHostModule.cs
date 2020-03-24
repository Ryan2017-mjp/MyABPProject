using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPProject.Configuration;

namespace ABPProject.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPProjectWebCoreModule))]
    public class ABPProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPProjectWebHostModule).GetAssembly());
        }
    }
}
